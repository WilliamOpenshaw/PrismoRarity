using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    public Transform player; 
    public float enemySpeed;     

    void Start()
    {
        enemySpeed = 0.03f;
    }
    void Update()
    {
        transform.LookAt(player);
    }

    public void FixedUpdate()
    {
        gameObject.GetComponent<Rigidbody>().AddRelativeForce(0, 0, enemySpeed, ForceMode.VelocityChange);
    }
}
    
    
