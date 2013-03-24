using UnityEngine;

public class BoxRespawner : MonoBehaviour {
    void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Box") return;
        var box = other.GetComponent<Box>();
        box.Respawn();
    }
}
