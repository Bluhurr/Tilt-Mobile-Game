using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour {

    public GameObject crossOutSounds;
    //public GameObject crossOutMusic;
    public AudioSource addPoint;
    public AudioSource death;

    void Start () {

        addPoint.volume = 1f;
        death.volume = 1;

        if (PlayerPrefs.GetInt("Sounds") != 0)
        {
            //addPoint.minDistance = 0f;
            //death.minDistance = 0f;
            //AudioListener.pause = true;
            addPoint.enabled = false;
            death.enabled = false;
            crossOutSounds.SetActive(true);
            PlayerPrefs.SetInt("Sounds", 1);
        }
        else
        {
            //addPoint.minDistance = 100f;
            //death.minDistance = 100f;
            addPoint.enabled = true;
            death.enabled = true;
            addPoint.volume = 1f;
            death.volume = 1;
            crossOutSounds.SetActive(false);
            PlayerPrefs.SetInt("Sounds", 0);
        }

        //if (PlayerPrefs.GetInt("Music") != 0)
        //{
        //    AudioListener.pause = true;
        //    addPoint.volume = 1;
        //    death.volume = 1;
        //    crossOutMusic.SetActive(true);
        //    PlayerPrefs.SetInt("Music", 1);
        //}
        //else
        //{
        //    AudioListener.pause = false;
        //    addPoint.volume = 0.7f;
        //    death.volume = 1f;
        //    crossOutMusic.SetActive(false);
        //    PlayerPrefs.SetInt("Music", 0);
        //}
    }

    public void toggleSounds()
    {
        if (PlayerPrefs.GetInt("Sounds") != 1)
        {
            //addPoint.minDistance = 100f;
            //death.minDistance = 100f;
            //AudioListener.pause = true;
            addPoint.enabled = false;
            death.enabled = false;
            crossOutSounds.SetActive(true);
            PlayerPrefs.SetInt("Sounds", 1);
        }
        else
        {
            //addPoint.minDistance = 0f;
            //death.minDistance = 0f;
            addPoint.enabled = true;
            death.enabled = true;
            crossOutSounds.SetActive(false);
            PlayerPrefs.SetInt("Sounds", 0);
        }
    }

    //public void toggleMusic()
    //{
    //    if (PlayerPrefs.GetInt("Music") != 1)
    //    {
    //        AudioListener.pause = true;
    //        addPoint.volume = 1;
    //        death.volume = 1;
    //        crossOutMusic.SetActive(true);
    //        PlayerPrefs.SetInt("Music", 1);
    //    }
    //    else
    //    {
    //        AudioListener.pause = false;
    //        addPoint.volume = 0.7f;
    //        death.volume = 1f;
    //        crossOutMusic.SetActive(false);
    //        PlayerPrefs.SetInt("Music", 0);
    //    }
    //}
}
