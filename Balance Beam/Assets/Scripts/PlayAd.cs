using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.UI;

public class PlayAd : MonoBehaviour {

    public GameObject showAdButton;
    public Text Coins;

    public void showAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show("video", new ShowOptions() { resultCallback = handleAdResult });
        }
    }

    private void handleAdResult(ShowResult result)
    {
        switch (result)
        {
            case ShowResult.Finished:
                Debug.Log("Ad was finished");
                PlayerPrefs.SetInt("numOfCoins", PlayerPrefs.GetInt("numOfCoins") + 20);
                Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
                break;
            case ShowResult.Skipped:
                Debug.Log("Ad was skipped");
                PlayerPrefs.SetInt("numOfCoins", PlayerPrefs.GetInt("numOfCoins") + 10);
                Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
                break;
            case ShowResult.Failed:
                Debug.Log("Ad failed to play, possibly because of internet");
                break; 
        }
    }

}
