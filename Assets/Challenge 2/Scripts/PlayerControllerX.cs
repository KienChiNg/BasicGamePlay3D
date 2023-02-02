using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float countDown = 2.0f;
    // Update is called once per frame
    void Update()
    {
        countDown -= Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(countDown <= 0){
                SpawnDog();
                countDown = 2.0f;
            }
        }
    }
    void SpawnDog(){
        Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
    }
}
