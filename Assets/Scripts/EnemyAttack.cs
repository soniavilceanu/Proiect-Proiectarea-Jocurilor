using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PLayer")
        {
           other.gameObject.SetActive(false);
        }
        else if (other.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}