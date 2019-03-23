using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockSkinManager : MonoBehaviour {

    public GameObject smileyButton;
    public GameObject racingButton;
    public GameObject bubbleButton;
    public GameObject andyButton;
    public GameObject dogeButton;
    public GameObject solButton;

    public Button smiley;
    public Button racing;
    public Button bubble;
    public Button andy;
    public Button doge;
    public Button sol;

    public Text Coins;

    // Use this for initialization
    void Start () {
        // Uncomment to gain 10000 coins
        //PlayerPrefs.SetInt("numOfCoins", 100);

        // Uncomment to set reset Coins
        //PlayerPrefs.SetInt("numOfCoins", 0);

        // Uncomment to reset unlocked skins
        //PlayerPrefs.SetString("smileyUnlocked", "no");
        //PlayerPrefs.SetString("racingUnlocked", "no");
        //PlayerPrefs.SetString("bubbleUnlocked", "no");
        //PlayerPrefs.SetString("andyUnlocked", "no");
        //PlayerPrefs.SetString("dogeUnlocked", "no");
        //PlayerPrefs.SetString("solUnlocked", "no");

        // Uncomment to unlock all skins
        //PlayerPrefs.SetString("smileyUnlocked", "yes");
        //PlayerPrefs.SetString("racingUnlocked", "yes");
        //PlayerPrefs.SetString("bubbleUnlocked", "yes");
        //PlayerPrefs.SetString("andyUnlocked", "yes");
        //PlayerPrefs.SetString("dogeUnlocked", "yes");
        //PlayerPrefs.SetString("solUnlocked", "yes");

        if (PlayerPrefs.GetString("smileyUnlocked") != "yes")
        {
            smileyButton.SetActive(true);
            smiley.interactable = false;
        }
        else
        {
            smileyButton.SetActive(false);
            smiley.interactable = true;
        }

        if (PlayerPrefs.GetString("racingUnlocked") != "yes")
        {
            racingButton.SetActive(true);
            racing.interactable = false;
        }
        else
        {
            racingButton.SetActive(false);
            racing.interactable = true;
        }

        if (PlayerPrefs.GetString("bubbleUnlocked") != "yes")
        {
            bubbleButton.SetActive(true);
            bubble.interactable = false;
        }
        else
        {
            bubbleButton.SetActive(false);
            bubble.interactable = true;
        }

        if (PlayerPrefs.GetString("andyUnlocked") != "yes")
        {
            andyButton.SetActive(true);
            andy.interactable = false;
        }
        else
        {
            andyButton.SetActive(false);
            andy.interactable = true;
        }

        if (PlayerPrefs.GetString("dogeUnlocked") != "yes")
        {
            dogeButton.SetActive(true);
            doge.interactable = false;
        }
        else
        {
            dogeButton.SetActive(false);
            doge.interactable = true;
        }

        if (PlayerPrefs.GetString("solUnlocked") != "yes")
        {
            solButton.SetActive(true);
            sol.interactable = false;
        }
        else
        {
            solButton.SetActive(false);
            sol.interactable = true;
        }
    }

    public void unlockSmileySkin() 
    {
        if(PlayerPrefs.GetInt("numOfCoins") >= 100)
        {
            smileyButton.SetActive(false);                                              // Get rid of lock icon/button
            smiley.interactable = true;                                                 // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 100)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("smileyUnlocked", "yes");                             // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

    public void unlockRacingSkin()
    {
        if (PlayerPrefs.GetInt("numOfCoins") >= 100)
        {
            racingButton.SetActive(false);                                              // Get rid of lock icon/button
            racing.interactable = true;                                                 // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 100)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("racingUnlocked", "yes");                             // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

    public void unlockBubbleSkin()
    {
        if (PlayerPrefs.GetInt("numOfCoins") >= 200)
        {
            bubbleButton.SetActive(false);                                              // Get rid of lock icon/button
            bubble.interactable = true;                                                 // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 200)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("bubbleUnlocked", "yes");                             // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

    public void unlockAndySkin()
    {
        if (PlayerPrefs.GetInt("numOfCoins") >= 200)
        {
            andyButton.SetActive(false);                                                // Get rid of lock icon/button
            andy.interactable = true;                                                   // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 200)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("andyUnlocked", "yes");                               // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

    public void unlockDogeSkin()
    {
        if (PlayerPrefs.GetInt("numOfCoins") >= 300)
        {
            dogeButton.SetActive(false);                                                // Get rid of lock icon/button
            doge.interactable = true;                                                   // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 300)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("dogeUnlocked", "yes");                               // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

    public void unlockSolSkin()
    {
        if (PlayerPrefs.GetInt("numOfCoins") >= 1000)
        {
            solButton.SetActive(false);                                                  // Get rid of lock icon/button
            sol.interactable = true;                                                     // Make actual skin button interactable
            PlayerPrefs.SetInt("numOfCoins", (PlayerPrefs.GetInt("numOfCoins") - 1000)); // Decrease numOfCoins by cost amount

            PlayerPrefs.SetString("solUnlocked", "yes");                                 // Set player pref to keep skin unlocked

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        }
    }

}
