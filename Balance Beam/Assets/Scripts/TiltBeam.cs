using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TiltBeam : MonoBehaviour {

    public GameObject beam;

    public Animator anim;

    // smaller number = faster animation
    float crossSpeed = 0.1f;

    float animSpeed = 1.33f;

    int i;

    public void Start()
    {
        anim = beam.GetComponent<Animator>();
        anim.enabled = false;
    }

    public void tiltLeft()
    {
        //targetRotation = transform.rotation;
        //targetRotation *= Quaternion.AngleAxis(60, Vector3.up);
        //this.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 10f);
        //transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 10 * 10f * Time.deltaTime);

        anim.enabled = true;
        anim.speed = animSpeed;
        anim.CrossFade("tiltBeam", crossSpeed);
        i = 1;
    }

    public void tiltRight()
    {
        //this.transform.Rotate(Vector3.down * 30 * Time.deltaTime);
        //this.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
        if (i == 1)
        {
            anim.enabled = true;
            anim.speed = animSpeed;
            anim.CrossFade("tiltBeamRight", crossSpeed);
        }
    }
}
