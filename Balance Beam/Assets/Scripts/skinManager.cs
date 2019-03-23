using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class skinManager : MonoBehaviour {

    public Material ballMaterial;
    public GameObject player;
    public Material backgroundMaterial;

    public GameObject PlayerLight;
    public Text Logo;
    public Text Instructions;
    public Text TapToTilt;
    public Text TapToRetry;
    public GameObject MainBlueLight;

    void Start ()
    {
        //if (PlayerPrefs.GetString("BallColor") != "SmileySkin")
        //{
        //    ballMaterial.SetColor("_EmissionColor", new Color32(0x9F, 0x2B, 0x00, 0xFF)); // Default color: #9F2B00
        //    ballMaterial.color = new Color32(0xF5, 0xFF, 0x4D, 0xFF);
        //}

        if (PlayerPrefs.GetString("BallColor") == "Default" || PlayerPrefs.GetString("BallColor") == "Cyan" || PlayerPrefs.GetString("BallColor") == "Blue" ||
            PlayerPrefs.GetString("BallColor") == "Green" || PlayerPrefs.GetString("BallColor") == "Yellow" || PlayerPrefs.GetString("BallColor") == "Pink" ||
            PlayerPrefs.GetString("BallColor") == "Purple" || PlayerPrefs.GetString("BallColor") == "White" || PlayerPrefs.GetString("BallColor") == "Black")
        {
            player.GetComponent<MeshRenderer>().material = ballMaterial;
        }

        // Check color playerpref and set to proper color
        if (PlayerPrefs.GetString("BallColor") == "Default"){ setDefault();}
        if (PlayerPrefs.GetString("BallColor") == "Cyan")   { setCyan();   }
        if (PlayerPrefs.GetString("BallColor") == "Blue")   { setBlue();   }
        if (PlayerPrefs.GetString("BallColor") == "Red")    { setRed();    }
        if (PlayerPrefs.GetString("BallColor") == "Green")  { setGreen();  }
        if (PlayerPrefs.GetString("BallColor") == "Yellow") { setYellow(); }
        if (PlayerPrefs.GetString("BallColor") == "Pink")   { setPink();   }
        if (PlayerPrefs.GetString("BallColor") == "Purple") { setPurple(); }
        if (PlayerPrefs.GetString("BallColor") == "White")  { setWhite();  }
        if (PlayerPrefs.GetString("BallColor") == "Black")  { setBlack();  }
    }

    public void setDefault()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x9F, 0x2B, 0x00, 0xFF)); // Default color: #9F2B00
        ballMaterial.color = new Color32(0xF5, 0xFF, 0x4D, 0xFF);                     // Extra yellow/orangeness color hex: #F5FF4DFF
        PlayerPrefs.SetString("BallColor", "Default");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setCyan()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x64, 0x9F, 0xFF)); // Cyan color hex: #00649F
        ballMaterial.color = new Color32(0x00, 0xFF, 0xF4, 0xFF);                     // Extra cyanness hex: #00FFF4FF
        PlayerPrefs.SetString("BallColor", "Cyan");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setBlue()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x0D, 0xDf, 0xFF)); // Blue color hex: #000DFF
        ballMaterial.color = new Color32(0x1E, 0xBE, 0xFF, 0xFF);                     // Extra blueness color hex: #1EBEFFFF
        PlayerPrefs.SetString("BallColor", "Blue");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setRed()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0xFF, 0x05, 0x00, 0xFF)); // Red color hex: #FF0500
        ballMaterial.color = new Color32(0xFF, 0xCF, 0x00, 0xFF);                     // Extra redness color hex: #FFCF00FF
        PlayerPrefs.SetString("BallColor", "Red");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setGreen()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x31, 0x6D, 0x00, 0xFF)); // Green color hex: #316D00
        ballMaterial.color = new Color32(0x6D, 0xFF, 0xB0, 0xFF);                     // Extra greenness hex: #6DFFB0FF
        PlayerPrefs.SetString("BallColor", "Green");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setYellow()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x9C, 0x90, 0x33, 0xFF)); // Yellow color hex: #9C9033
        ballMaterial.color = new Color32(0xFF, 0xF6, 0x78, 0xFF);                     // Extra yellowness color hex: #FFF678FF
        PlayerPrefs.SetString("BallColor", "Yellow");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setPink()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0xD8, 0x3C, 0xD3, 0xFF)); // Pink color hex: #D83CD3
        ballMaterial.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        PlayerPrefs.SetString("BallColor", "Pink");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setPurple()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x92, 0x00, 0xFF, 0xFF)); // Purple color hex: #9200FF
        ballMaterial.color = new Color32(0x13, 0xCE, 0xE8, 0xFF);                     // Extra purpleness color hex: #13CEE8FF
        PlayerPrefs.SetString("BallColor", "Purple");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setWhite()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x7C, 0x7C, 0x7C, 0xFF)); // White color hex: #7C7C7C
        ballMaterial.color = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
        PlayerPrefs.SetString("BallColor", "White");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

    public void setBlack()
    {
        player.GetComponent<MeshRenderer>().material = ballMaterial;
        ballMaterial.SetColor("_EmissionColor", new Color32(0x05, 0x05, 0x05, 0xFF)); // Black color hex: #050505
        ballMaterial.color = new Color32(0xC9, 0xC9, 0xC9, 0xFF);                     // Black extraness hex: #C9C9C9FF
        PlayerPrefs.SetString("BallColor", "Black");


        PlayerLight.SetActive(false);
        MainBlueLight.SetActive(true);

        Logo.color = new Color32(0x00, 0xB5, 0xFF, 0xFF);           // 00B5FFFF
        Instructions.color = new Color32(0x51, 0xBE, 0xFF, 0xC2);   // 51BEFFC2
        TapToTilt.color = new Color32(0xFF, 0x9B, 0x2F, 0xAF);      // FF9B2FAF
        backgroundMaterial.SetColor("_EmissionColor", new Color32(0x00, 0x4C, 0xB4, 0xFF)); // Main background color: 004CB4
        backgroundMaterial.color = new Color32(0x72, 0xFF, 0xB3, 0xFF);                     // Extra background color: 72FFB3FF
    }

}
