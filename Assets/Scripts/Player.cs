using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    Rigidbody playerRigi;
    
    [SerializeField]
    public float speed=0;

    [SerializeField]
    public GameObject camera;

    float verticalInput;



    private void Start()
    {
        playerRigi = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        verticalInput = Input.GetAxis("Vertical");
        playerRigi.AddForce(camera.transform.forward * speed * verticalInput);
    }
}