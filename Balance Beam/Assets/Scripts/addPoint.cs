using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.Animations;

public class addPoint : MonoBehaviour {

    public GameObject playerBall;
    public GameObject beep;
    int i = 2;
    int j;
    int k;

    public Text Score;
    public Text Coins;
    public int score = 0;
    public int highscore;

    public int numOfCoins = 0;

    public GameObject plusTwo;
    public Animator plusAnim;

    public GameObject scoreSize;
    public Animator scoreAnim;

    void Start()
    {
        Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();
        plusAnim = plusTwo.GetComponent<Animator>();
        plusAnim.enabled = false;

        scoreAnim = scoreSize.GetComponent<Animator>();
        scoreAnim.enabled = false;
    }

    void Update()
    {
        if (playerBall.transform.position.x > 0 && i != 0)
        {
            beep.GetComponent<AudioSource>().Play();
            Debug.Log("Plus one point for going right");
            score++;
            Score.text = score.ToString();

            scoreAnim.Play("point", -1, 0);
            scoreAnim.enabled = true;
            scoreAnim.CrossFade("point", 1);

            i = 0;
        }
        if (playerBall.transform.position.x < 0 && i == 0)
        {
            beep.GetComponent<AudioSource>().Play();
            Debug.Log("Plus one point for going left");
            score++;
            Score.text = score.ToString();

            scoreAnim.Play("point", -1, 0);
            scoreAnim.enabled = true;
            scoreAnim.CrossFade("point", 1);

            i = 1;
        }


        // CODE FOR COIN SYSTEM ---------------------------------------------------

        //PlayerPrefs.SetInt("numOfCoins", 0);      // Uncomment to set coins to 0
        if (score % 10 == 0 && j != 1 && score > 0)
        {
            //Add 2 coins
            numOfCoins = PlayerPrefs.GetInt("numOfCoins") + 2;

            PlayerPrefs.SetInt("numOfCoins", numOfCoins);

            Coins.text = PlayerPrefs.GetInt("numOfCoins").ToString();

            plusAnim.Play("plusTwo", -1, 0);
            plusAnim.enabled = true;
            plusAnim.CrossFade("plusTwo", 1);

            j = 1;
        }
        else if(score % 10 > 0 && j == 1)
        {
            j = 0;
        }
        // END OF COIN SYSTEM CODE -----------------------------------------------------

        //Uncomment this \/\/ line of code to reset highscore for testing 
        //PlayerPrefs.SetFloat("Highscore", 0);
        if (PlayerPrefs.GetFloat("Highscore") <= score)
        {
            PlayerPrefs.SetFloat("Highscore", score);
            highscore = score;
        }
    }
}
