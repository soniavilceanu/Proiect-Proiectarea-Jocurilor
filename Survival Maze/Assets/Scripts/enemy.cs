using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Transform player;
    private float dist;
    public float moveSpeed;
    public float howclose;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("PLayer").transform;

    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(player.position, transform.position);
        if (dist <= howclose && dist > 2f)
        {
            //transform.LookAt(player);
            Vector3 localPosition = player.transform.position - transform.position;
            localPosition = localPosition.normalized;
            transform.Translate(localPosition.x * Time.deltaTime * moveSpeed,
                localPosition.y * moveSpeed, // sau 0f   
                localPosition.z * Time.deltaTime * moveSpeed);
        }
        //for attack or explosive
        if (dist <= 1.5f)
        {
            //do damage or explode
        }
    }
}
