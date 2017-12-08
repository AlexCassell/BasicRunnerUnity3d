using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class powerUpandScore : MonoBehaviour
{

    [SerializeField]
    private Text scoreUI;


    private int score;

    public AudioClip powerUp;
    public AudioClip powerDown;



    private AudioSource source;

    void Awake()
    {
        source = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "coin")
        {
            if(other.gameObject.GetComponent<coins>().randomNumber == 1)
            {
                source.PlayOneShot(powerDown);
                score -= 2;
                //Debug.Log(score);
                scoreUI.text = score.ToString();
            }
            else
            {
                source.PlayOneShot(powerUp);
                score += 1;
                //Debug.Log(score);
                scoreUI.text = score.ToString();
            }

        }

    }
}
