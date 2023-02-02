using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBounds : MonoBehaviour
{
    [SerializeField] private float topBound = 30.0f;
    [SerializeField] private float lowerBound;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Abs(transform.position.x) > topBound)
        {
            Destroy(gameObject);
        }
        else if (Mathf.Abs(transform.position.z) > lowerBound)
        {
            // Debug.Log("GameOver");
            Destroy(gameObject);
        }
    }
}
