using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    private int health = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        health --;
        // Debug.Log(health);
        if (health == 0){
            Destroy(gameObject);
        }
        Destroy(other.gameObject);
    }
}
