using UnityEngine;

public class SecretFinish : MonoBehaviour
{
    public GameObject habr;
    public GameObject room;
    public GameObject cam;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.rigidbody.velocity = Vector3.zero;
            other.rigidbody.useGravity = true;
            other.GetComponent<PlayerController>().enabled = false;
                
            other.rigidbody.constraints = RigidbodyConstraints.FreezeRotationY |
                                            RigidbodyConstraints.FreezeRotationZ;
            other.rigidbody.AddTorque(-1, 0, 0, ForceMode.Impulse);

            habr.transform.localScale = Vector3.one;
            room.SetActive(false);
            cam.camera.far = 1000;
        }
    }
}
