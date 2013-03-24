using UnityEngine;
using System.Collections.Generic;

public class BlueButton : MonoBehaviour
{
    public GameObject Button;
    public GameObject[] Mechanisms;

    private List<Collider> colliders = new List<Collider>();
    private bool pressed = false;

    void Update()
    {

        if (colliders.Count > 0 && !pressed)
        {
            foreach (var mech in Mechanisms)
                if(mech != null)
                    mech.SetActive(false);
            
            Button.transform.localPosition += new Vector3(0, 0, 0.3f);
            Button.renderer.material.color = new Color(1, 0.098f, 0.098f);
            pressed = true;
        }
        else if (colliders.Count == 0 && pressed)
        {
            foreach (var mech in Mechanisms)
                if (mech != null)
                    mech.SetActive(true);
            
            Button.transform.localPosition -= new Vector3(0, 0, 0.3f);
            Button.renderer.material.color = new Color(0.212f, 0.098f, 1);
            pressed = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        colliders.Add(other);
    }

    void OnTriggerExit(Collider other)
    {
        colliders.Remove(other);
    }
}
