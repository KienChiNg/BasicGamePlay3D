using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float horizontalInput;
    private float verticalInput;
    [SerializeField] private float xRange = 20.0f;
    [SerializeField] private float zRange = 20.0f;
    [SerializeField] private float speed;
    [SerializeField] private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Keep player in bounds
        if (Mathf.Abs(transform.position.x) > xRange){
            transform.position = new Vector3(
                (transform.position.x < 0 ? -xRange : xRange),
                transform.position.y,
                transform.position.z);
        }
        if (Mathf.Abs(transform.position.z) > zRange){
            transform.position = new Vector3(
                transform.position.x,
                transform.position.y,
                (transform.position.z < 0 ? -zRange : zRange));
        }
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        if (Input.GetKeyDown(KeyCode.Space)){
            Instantiate(projectile,transform.position,projectile.transform.rotation);
        }
    }
}
