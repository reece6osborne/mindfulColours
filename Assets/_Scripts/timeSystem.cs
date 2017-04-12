using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{

    public float gracePeriod;
    public float length;
    public Text timerText;
    public Text gameOverText;
    public Text gpText;

	// Use this for initialization
	void Start ()
    {
        gracePeriod = 3;
        length = 30;
        timerText.text = "";
        gameOverText.text = "";
	}
	
	// Update is called once per frame
	void Update ()
    {
        //Gives the player time to get ready
        if (gracePeriod > 0)
        {
            gracePeriod -= Time.deltaTime;
            gpText.text = "" + gracePeriod.ToString("f0");
        }
        else if (gracePeriod <= 0)
        {

            gpText.gameObject.SetActive(false);

            if (length > 0 && gracePeriod <= 0)
            {
                length -= Time.deltaTime;
                timerText.text = "" + length.ToString("f0");

                //Hide unwanted elements
                gameOverText.gameObject.SetActive(false);
            }
            else if (length <= 0 && gracePeriod <= 0)
            {
                length = length + 0;
                timerText.text = "" + length.ToString("f0");
                gameOverText.text = "Game Complete";

                //Hide and display correct end game text
                timerText.gameObject.SetActive(false);
                gameOverText.gameObject.SetActive(true);
            }
        }
	}
}
