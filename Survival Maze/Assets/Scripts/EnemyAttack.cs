/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public Player_Controller player;
    private Transform m_player;
    public float dist;
    public HealthBar healthBar;

    void Start()
    {
       healthBar.setMaxHealth(8000);
       m_player = GameObject.FindGameObjectWithTag("PLayer").transform;
    }
    
    void Update()
    {
        if(healthBar.getcurrentHealth() == 0)
            Destroy(gameObject);
        /* 
         else if (Input.GetKeyDown(KeyCode.Space) == true)
         {
             healthBar.takeDamage(10);
         }
       

        dist = Vector3.Distance(m_player.position, transform.position);
        if(dist <= 3)
        {
            if (player.healthBar.getcurrentHealth() == 0)
                SceneManager.LoadScene("DeathScreen");
            else
            {
                //StartCoroutine(WaitForSeconds());
                player.healthBar.takeDamage(4);
                // sa ia damage constant (de exemplu 20 puncte de damage pe secundA) cand e atins
            }
        }


    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bullet")
        {

            healthBar.takeDamage(10);
        }
    }
}
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public Player_Controller player;
    private Transform m_player;
    public float dist;
    public HealthBar healthBar;
    public float damTimer;

    void Start()
    {
        damTimer = 0;
       healthBar.setMaxHealth(200);
       m_player = GameObject.FindGameObjectWithTag("PLayer").transform;
    }
    
    void Update()
    {
        if (damTimer > 0)
        {
            damTimer -= Time.deltaTime;
            if (healthBar.getcurrentHealth() == 0)
                Destroy(gameObject);
        }
        /* 
         else if (Input.GetKeyDown(KeyCode.Space) == true)
         {
             healthBar.takeDamage(10);
         }
       */

        dist = Vector3.Distance(m_player.position, transform.position);
        if(dist <= 3)
        {
            if (damTimer <= 0)
            {
                if (player.healthBar.getcurrentHealth() == 0)
                    SceneManager.LoadScene("DeathScreen");
                else
                {
                        //StartCoroutine(WaitForSeconds());
                        player.healthBar.takeDamage(7);
                        // sa ia damage constant (de exemplu 20 puncte de damage pe secundA) cand e atins
                 }
                    damTimer = 1;
                }
        }


    }
    
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Bullet")
        {

            healthBar.takeDamage(10);
        }
    }
}

/*

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyAttack : MonoBehaviour
{
    public Player_Controller player;

    public HealthBar healthBar;

    void Start()
    {
        healthBar.setMaxHealth(80);
    }

    void Update()
    {
        if (healthBar.getcurrentHealth() == 0)
            Destroy(gameObject);

        else if (Input.GetKeyDown(KeyCode.Space) == true)
        {
            healthBar.takeDamage(20);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "PLayer")
        {
            if (player.healthBar.getcurrentHealth() == 0)
                SceneManager.LoadScene("DeathScreen");
            else
            {
                player.healthBar.takeDamage(20);
                // sa ia damage constant (de exemplu 20 puncte de damage pe secundA) cand e atins
            }
        }
        else if (other.tag == "Bullet")
        {
            healthBar.takeDamage(20);
        }
    }
}
        */
