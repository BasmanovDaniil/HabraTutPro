using UnityEngine;

public class GreenButton : MonoBehaviour
{
    public GameObject Button;
    public GameObject[] Mechanisms;

    void OnTriggerEnter(Collider other)
    {
        foreach (var mech in Mechanisms)
            Destroy(mech);

        Button.transform.localPosition += new Vector3(0, 0, 0.3f);
        Button.renderer.material.color = new Color(1, 0.098f, 0.098f);
        collider.enabled = false;
    }

}
