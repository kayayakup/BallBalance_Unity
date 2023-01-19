using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallowPlayer : MonoBehaviour
{
    [SerializeField]
    Vector3 forwardOffset = new Vector3(0, 2, -4);

    [SerializeField]
    Transform player;

    float horizontalInput;
    private void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(new Vector3(0, 103.0f, 0) * Time.deltaTime * horizontalInput, Space.World);
        transform.position = Vector3.Lerp(transform.position, player.position + forwardOffset, 1.0f);
        //transform.LookAt(player);
    }
}