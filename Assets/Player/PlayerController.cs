using UnityEngine;

public class PlayerController : MonoBehaviour {
    public int acceleration;

	void FixedUpdate () {
        var direction = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;
        rigidbody.AddForce(direction * acceleration);
        if (direction == Vector3.zero)
        {
            direction = new Vector3(Input.GetAxis("Horizontal LS"), Input.GetAxis("Vertical LS"), 0).normalized;
            rigidbody.AddForce(direction * acceleration);
        }

        if (Input.GetButton("Jump") || Input.GetButton("A"))
	    {
	        var small = Physics.OverlapSphere(transform.position, 0.6f);
	        var big = Physics.OverlapSphere(transform.position, 2.1f);

	        foreach (var body in big)
	            if (System.Array.IndexOf(small, body) == -1 && body.tag == "Box")
	                body.rigidbody.AddForce((transform.position - body.transform.position) * 20);
	    }
	}
}