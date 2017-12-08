using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class possibleCoins : MonoBehaviour {

    [SerializeField]
    private GameObject coinBarLocationOne;
    [SerializeField]
    private GameObject coinBarLocationTwo;
    [SerializeField]
    private GameObject coinBarLocationThree;
    [SerializeField]
    private GameObject coinLineLocationOne;
    [SerializeField]
    private GameObject coinLineLocationTwo;

    private int randomNumber;
    void Start () {
        coinBarLocationOne.SetActive(false);
        coinBarLocationTwo.SetActive(false);
        coinBarLocationThree.SetActive(false);
        coinLineLocationOne.SetActive(false);
        coinLineLocationTwo.SetActive(false);
        setCoins();
    }

	void setCoins () {
        randomNumber = Random.Range(1, 5);
      //  Debug.Log("Location" + randomNumber);
        if (randomNumber == 1)
        {
            coinBarLocationOne.SetActive(true);
        }
        else if (randomNumber == 2)
        {
            coinBarLocationTwo.SetActive(true);
        }
        else if (randomNumber == 3)
        {
            coinBarLocationThree.SetActive(true);
        }
        else if (randomNumber == 4)
        {
            coinLineLocationOne.SetActive(true);
        }
        else if (randomNumber == 5)
        {
            coinLineLocationTwo.SetActive(true);
        }

    }
}
