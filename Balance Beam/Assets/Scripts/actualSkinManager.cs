using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class actualSkinManager : MonoBehaviour {

    public GameObject player;

    public Material ballMaterial;
    public Material smileyMaterial;
    public Material dogeMaterial;
    public Material RacingStripesMaterial;
    public Material ToyStoryMaterial;
    public Material GlowMaterial;
    public Material BubbleMaterial;

    public Material backgroundMaterial;

    public GameObject PlayerLight;
    public Text Logo;
    public Text Instructions;
    public Text TapToTilt;
    public Text TapToRetry;
    public GameObject MainBlueLight;

    // Use this for initialization
    void Start ()
    {

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF

        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF


        if (PlayerPrefs.GetString("BallColor") == "SmileySkin") {setSmiley();}
        if (PlayerPrefs.GetString("BallColor") == "Doge") {setDoge();}
        if (PlayerPrefs.GetString("BallColor") == "RacingStripes") { setRacing(); }
        if (PlayerPrefs.GetString("BallColor") == "ToyStory") { setToyStory(); }
        if (PlayerPrefs.GetString("BallColor") == "GlowBall") { setGlowBall(); }
        if (PlayerPrefs.GetString("BallColor") == "Bubble") { setBubbleBall(); }

    }

    public void setSmiley()
    {
        PlayerPrefs.SetString("BallColor", "SmileySkin");

        ballMaterial.SetColor("_EmissionColor", new Color32(0xB4, 0x78, 0x00, 0xFF)); // Yellow #B47800
        ballMaterial.color = new Color32(0xF5, 0xFF, 0x4D, 0xFF);                     // Extra Yellowness: #FFF678FF

        player.GetComponent<MeshRenderer>().material = smileyMaterial;

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setDoge()
    {
        PlayerPrefs.SetString("BallColor", "Doge");

        ballMaterial.SetColor("_EmissionColor", new Color32(0xA1, 0x7F, 0x6A, 0xFF)); // A17F6A
        ballMaterial.color = new Color32(0x6E, 0x74, 0x02, 0xFF);                     // 6E7402FF

        player.GetComponent<MeshRenderer>().material = dogeMaterial;

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setRacing()
    {
        PlayerPrefs.SetString("BallColor", "RacingStripes");

        ballMaterial.SetColor("_EmissionColor", new Color32(0xFF, 0x05, 0x00, 0xFF)); // Red color hex: #FF0500
        ballMaterial.color = new Color32(0xFF, 0xCF, 0x00, 0xFF);                     // Extra redness color hex: #FFCF00FF

        player.GetComponent<MeshRenderer>().material = RacingStripesMaterial ;

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setToyStory()
    {
        PlayerPrefs.SetString("BallColor", "ToyStory");

        ballMaterial.SetColor("_EmissionColor", new Color32(0xB4, 0x7B, 0x01, 0xFF)); // Orange/Yellow color hex: #B47B01
        ballMaterial.color = new Color32(0xFF, 0xCF, 0x00, 0xFF);                     // Extra yellowness color hex: #FFCF00FF

        player.GetComponent<MeshRenderer>().material = ToyStoryMaterial;

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setGlowBall()
    {
        PlayerPrefs.SetString("BallColor", "GlowBall");

        // We'll get to this a lil later
        ballMaterial.SetColor("_EmissionColor", new Color32(0xFF, 0xFF, 0xFF, 0xFF)); // Orange/Yellow color hex: #B47B01
        ballMaterial.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);                     // Extra yellowness color hex: #FFCF00FF

        player.GetComponent<MeshRenderer>().material = GlowMaterial;

        Logo.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);           
        Instructions.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        TapToTilt.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        TapToRetry.color = new Color32(0xFF, 0xFF, 0xFF, 0x00);

        PlayerLight.SetActive(true);
        MainBlueLight.SetActive(false);

        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x17, 0x1A, 0xFF));  // 00171A
        backgroundMaterial.color = new Color32(0x00, 0x6A, 0x85, 0xFF);  // 006A85FF

    }

    public void setBubbleBall()
    {
        PlayerPrefs.SetString("BallColor", "Bubble");

        // We'll get to this a lil later
        ballMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4E, 0xCE, 0xFF)); // 004ECE
        ballMaterial.color = new Color32(0x00, 0xEA, 0xFF, 0xFF);                     // 00EAFFFF

        player.GetComponent<MeshRenderer>().material = BubbleMaterial;

        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }
}
