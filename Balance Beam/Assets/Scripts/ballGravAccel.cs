using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballGravAccel : MonoBehaviour {

    int yAccel = -195;
    public GameObject RetryButtonText;
    public GameObject RetryButton;

    public Animator fallInAnim;
    public Animator RetryButtonAppear;

    public GameObject bestScore;
    public Animator bestAnim;

    public GameObject numOfAttempts;
    public Animator attemptsAnim;

    public GameObject rateButton;
    public Animator rateAnim;

    public GameObject deathFlash;
    public Animator flashAnim;


    public GameObject boopAudio;

    public Text Score;
    public Text HighScore;

    public GameObject tapToStart;

    public GameObject getCoinsButton;
    int j = 0;
    int i = 0;
    int k = 0;

    void Start()
    {
        getCoinsButton.SetActive(true);
        rateButton.SetActive(false);
        rateAnim = rateButton.GetComponent<Animator>();
        rateAnim.enabled = false;
        tapToStart.SetActive(true);
        PlayerPrefs.SetString("DeadorNah", "Alive");
        fallInAnim = this.GetComponent<Animator>();
        RetryButtonAppear = RetryButtonText.GetComponent<Animator>();
        RetryButtonAppear.enabled = false;
        bestAnim = bestScore.GetComponent<Animator>();
        attemptsAnim = numOfAttempts.GetComponent<Animator>();
        flashAnim = deathFlash.GetComponent<Animator>();

        rateButton.GetComponent<Image>().raycastTarget = false;

        bestAnim.enabled = false;
        attemptsAnim.enabled = false;
        fallInAnim.enabled = true;
        flashAnim.enabled = false;
        fallInAnim.Play("BallFallIntoScreen");
        HighScore.text = PlayerPrefs.GetFloat("Highscore").ToString();
    }

    void FixedUpdate()
    {
        if (fallInAnim.enabled == false)
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, yAccel), ForceMode.Acceleration);
        }

        if (i == 0)
        {
            if (this.transform.position.x < -0.453f || this.transform.position.x > -0.449f && i != 1)
            {
                tapToStart.SetActive(false);
                i = 1;
            }
        }
    }

    // Update is called once per frame
    void Update () {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------
        //if (fallInAnim.enabled == false)                                                              // THIS IS ALL PHYSICS SO IT WAS MOVED TO FIXED UPDATE
        //{
        //    this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, yAccel), ForceMode.Acceleration);
        //}

        //if (i == 0)
        //{
        //    if (this.transform.position.x < -0.453f || this.transform.position.x > -0.449f && i != 1)
        //    {
        //        tapToStart.SetActive(false);
        //        i = 1;
        //    }
        //}
        //-----------------------------------------------------------------------------------------------------------------------------------------------------


        // >>>> DEAD STUFF <<<<<
        if (this.transform.position.y < -1.72)
        {
            if (j == 0)
            {
                boopAudio.GetComponent<AudioSource>().Play();
                j = 1;
            }
            if (!(PlayerPrefs.GetInt("numOfTries") % 3 == 0) || PlayerPrefs.GetInt("numOfTries") == 0) 
            {
                getCoinsButton.SetActive(false);
            }
            rateButton.SetActive(true);
            RetryButton.GetComponent<Image>().raycastTarget = true;
            RetryButtonAppear.enabled = true;
            RetryButtonAppear.Play("RetryButtonAppear");
            HighScore.text = PlayerPrefs.GetFloat("Highscore").ToString();
            bestAnim.enabled = true;
            bestAnim.Play("BestScore");
            attemptsAnim.enabled = true;
            attemptsAnim.Play("numOfAttempts");
            rateAnim.enabled = true;
            rateAnim.Play("rateButton");
            rateButton.GetComponent<Image>().raycastTarget = true;
            flashAnim.enabled = true;
            flashAnim.Play("deathFlash");
        }
	}

    public void stopAnimatingPlayer()
    {
        fallInAnim.enabled = false;
        this.transform.position = new Vector3(0f, 0.45f, 0f);
        //this.GetComponent<Rigidbody>().AddForce(new Vector3(0f, 500), ForceMode.Acceleration);
    }
}
