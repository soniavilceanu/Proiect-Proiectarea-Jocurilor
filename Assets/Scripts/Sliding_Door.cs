using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sliding_Door : MonoBehaviour
{
    /**
    public Transform door;
    public float move_speed = 1;
    public float size_of_door_y = 1;
    public float door_in_wall = 0.8f;
    
    private Vector3 door_closed;
    private Vector3 door_open;
    private float start_time;
    private float distance_to_cover;

    private bool is_door_open = false;
    private bool is_door_open_button_pressed = false;

    void Start()
    {
        set_initial_references();
    }

    
    void Update()
    {
        open_door();
    }

    void set_initial_references()
    {
        door_closed = door.localPosition;

        door_open = new Vector3(door.localPosition.x,
                                door.localPosition.y - (size_of_door_y * door_in_wall),
                                door.localPosition.z);
        
        distance_to_cover = Vector3.Distance(door_closed, door_open);
    }

    void open_door()
    {
        if(is_door_open || !is_door_open_button_pressed)
            return;
        
        float distance_covered = (Time.time - start_time) * move_speed;
        float fraction_of_flight = distance_covered / distance_to_cover;

        door.localPosition = Vector3.Lerp(door.localPosition, door_open, fraction_of_flight);

        if(Mathf.Approximately(door.localPosition.y, door_open.y))
        {
            Debug.Log("Door opened");
            is_door_open = true;
            is_door_open_button_pressed = false;
        }
    }

    public void button_open_door()
        {
            if(is_door_open)
                return;
            
            start_time = Time.time;
            is_door_open_button_pressed = true;
        }
    */

    public enum OpenDirection
    {
        x,
        y,
        z
    };

    public OpenDirection direction = OpenDirection.y;
    public float open_distance = 5;
    public float open_speed = 2.0f;
    public Transform door;

    private bool is_door_open = false;

    private Vector3 default_door_position;

    void Start()
    {
        if (door)
            default_door_position = door.localPosition;
    }

    void Update()
    {
        if (!door)
            return;

        /*if (direction == OpenDirection.x)
            door.localPosition = new Vector3(Mathf.Lerp(door.localPosition.x,
                                                           default_door_position.x + (is_door_open ? open_distance: 0),
                                                           Time.deltaTime * open_speed),
                                             door.localPosition.y,
                                             door.localPosition.z);*/
        //else
            if(direction == OpenDirection.y)
                door.localPosition = new Vector3(door.localPosition.x,
                                                 Mathf.Lerp(door.localPosition.y,
                                                               default_door_position.y + (is_door_open ? open_distance: 0),
                                                               Time.deltaTime * open_speed),
                                                 door.localPosition.z);
            /*else
            if(direction == OpenDirection.y)
                door.localPosition = new Vector3(door.localPosition.x,
                                                 door.localPosition.y,
                                              Mathf.Lerp(door.localPosition.z,
                                                            default_door_position.z + (is_door_open ? open_distance: 0),
                                                            Time.deltaTime * open_speed));*/
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("PLayer"))
            is_door_open = true;
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("PLayer"))
            is_door_open = false;
    }
}
