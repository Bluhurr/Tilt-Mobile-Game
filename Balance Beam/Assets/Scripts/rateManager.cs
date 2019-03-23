using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rateManager : MonoBehaviour {

    public string RatePageURL = "market://details?id=com.Blu3Games.Tilt";


    public void RedirectToRatePageAndroid()
    {
        Application.OpenURL(RatePageURL);
    }
}
