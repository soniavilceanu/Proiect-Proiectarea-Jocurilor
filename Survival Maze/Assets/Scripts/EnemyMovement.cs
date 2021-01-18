/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float dist;
    public int EnemySpeed;
    private Transform m_player;
    public float howclose;
    private void Awake()
    {
        m_player = GameObject.FindGameObjectWithTag("PLayer").transform;
    }
    void Update()
    {
        dist = Vector3.Distance(m_player.position, transform.position);
        if (dist <= howclose && dist > 2f)
        {
            Vector3 localPosition = m_player.transform.position - transform.position;
            localPosition = localPosition.normalized;
            transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed,
                localPosition.y * EnemySpeed, // sau 0f   
                localPosition.z * Time.deltaTime * EnemySpeed);
        }
        //for attack or explosive
        if (dist <= 1.5f)
        {
            
        }
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public int EnemySpeed;
    GameObject m_player;
    private void Awake()
    {
        m_player = GameObject.Find("PLayer");
    }
    void Update()
    {
        Vector3 localPosition = m_player.transform.position - transform.position;
        localPosition = localPosition.normalized;
        transform.Translate(localPosition.x * Time.deltaTime * EnemySpeed,
            localPosition.y * EnemySpeed, // sau 0f   
            localPosition.z * Time.deltaTime * EnemySpeed);
    }
}