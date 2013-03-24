using UnityEngine;

public class ReturnControl : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.rigidbody.constraints = RigidbodyConstraints.FreezeRotation | RigidbodyConstraints.FreezePositionZ;
            other.transform.position = new Vector3(other.transform.position.x, other.transform.position.y, 999);
            other.GetComponent<PlayerController>().enabled = true;
            enabled = false;
        }
    }
}
