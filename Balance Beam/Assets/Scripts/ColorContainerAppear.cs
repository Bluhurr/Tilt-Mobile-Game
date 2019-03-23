using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorContainerAppear : MonoBehaviour {

    public Animator anim;
    public GameObject colorContainer;

    void Start()
    {
        anim = colorContainer.GetComponent<Animator>();
        anim.enabled = false;
        PlayerPrefs.SetInt("Open", 0);
    }

    public void colorPaletteAppear()
    {
        if (PlayerPrefs.GetInt("Open") == 0)
        {
            anim.enabled = true;
            anim.CrossFade("ColorPick", 0.5f);
            PlayerPrefs.SetInt("Open", 1);
        }

        else if (PlayerPrefs.GetInt("Open") == 1)
        {
            anim.enabled = true;
            anim.CrossFade("ColorPickBack", 0.5f);
            PlayerPrefs.SetInt("Open", 0);
        }
    }

}
