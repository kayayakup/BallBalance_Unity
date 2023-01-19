using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetParent : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject parent;

    private void OnCollisionEnter(Collision collision)
    {
        player.GetComponent<Rigidbody>().mass = 100f;
    }

    private void OnCollisionExit(Collision collision)
    {
        player.GetComponent<Rigidbody>().mass = 1f;
    }
}
