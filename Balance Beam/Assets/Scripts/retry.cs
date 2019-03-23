using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class retry : MonoBehaviour
{
    int numOfTries = 0;
    public Text NumOfTriesText;
    int i = 0;

    void Start()
    {
        NumOfTriesText.text = PlayerPrefs.GetInt("numOfTries").ToString();
    }

    public void restartGame()
    {
        //PlayerPrefs.SetInt("numOfTries", 0);
        if (PlayerPrefs.GetInt("numOfTries") >= 1 && i != 1)
        {
            numOfTries = PlayerPrefs.GetInt("numOfTries");
            numOfTries++;
            PlayerPrefs.SetInt("numOfTries", numOfTries);
            i = 1;
        }
        else if (PlayerPrefs.GetInt("numOfTries") < 1 && i != 1) { PlayerPrefs.SetInt("numOfTries", 1); i = 1; }

        SceneManager.LoadScene("Game");
    }

}
