using UnityEngine;
using System.Collections.Generic;

public class SuperSecret : MonoBehaviour
{

    public GameObject supersecret;
    public GameObject player;

    private List<Collider> colliders = new List<Collider>();

    void Update()
    {
        if (colliders.Count == 4)
        {
            supersecret.SetActive(false);
            enabled = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Box")
            colliders.Add(other);
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Box")
            colliders.Remove(other);
    }
}
