using UnityEngine;

public class Box : MonoBehaviour
{

    private Vector3 initPosition;

	void Start ()
	{
	    initPosition = transform.position;
	}

	public void Respawn ()
	{
	    rigidbody.velocity = Vector3.zero;
	    transform.position = initPosition;
	}
}
