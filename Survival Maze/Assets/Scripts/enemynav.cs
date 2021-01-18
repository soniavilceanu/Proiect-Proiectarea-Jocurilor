using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class enemynav : MonoBehaviour
{
    public Transform Player;
    public NavMeshAgent agent;
    public float dist;
    public int EnemySpeed;
    private Transform m_player;
    public float howclose;
    // Start is called before the first frame update

    // Update is called once per frame

    private void Awake()
    {
        m_player = GameObject.FindGameObjectWithTag("PLayer").transform;
    }

    void Update()
    {
        dist = Vector3.Distance(m_player.position, transform.position);
        if (dist <= howclose && dist > 3f)
        {
            agent.destination = Player.position;
        }
        //for attack or explosive
        if (dist <= 1.5f)
        {

        }
    }

    
}