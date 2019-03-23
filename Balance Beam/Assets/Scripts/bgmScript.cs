using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgmScript : MonoBehaviour {

    public AudioSource bgm;
    public static GameObject bgmObject;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);

        if (bgmObject)
        {
            Destroy(gameObject);
            return;
        }

        bgm.Play();
        bgmObject = gameObject;
    }

}
