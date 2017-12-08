using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomBarricades : MonoBehaviour {

    [SerializeField]
    private GameObject rightOne;
    [SerializeField]
    private GameObject rightTwo;
    [SerializeField]
    private GameObject rightThree;
    [SerializeField]
    private GameObject rightFour;
    [SerializeField]
    private GameObject rightFive;
    [SerializeField]
    private GameObject rightSix;
    [SerializeField]
    private GameObject rightSeven;

    [SerializeField]
    private GameObject leftOne;
    [SerializeField]
    private GameObject leftTwo;
    [SerializeField]
    private GameObject leftThree;
    [SerializeField]
    private GameObject leftFour;
    [SerializeField]
    private GameObject leftFive;
    [SerializeField]
    private GameObject leftSix;
    [SerializeField]
    private GameObject leftSeven;

    private int randomNumber;

    private int Count;

    void Start () {
        Count = 0;
        leftOne.SetActive(false);
        leftTwo.SetActive(false);
        leftThree.SetActive(false);
        leftFour.SetActive(false);
        leftFive.SetActive(false);
        leftSix.SetActive(false);
        leftSeven.SetActive(false);
        rightOne.SetActive(false);
        rightTwo.SetActive(false);
        rightThree.SetActive(false);
        rightFour.SetActive(false);
        rightFive.SetActive(false);
        rightSix.SetActive(false);
        rightSeven.SetActive(false);

        chooseBarricades();
    }

    private void chooseBarricades()
    {
        if(Count < 5)
        {
            randomNumber = Random.Range(1, 5);
            if (randomNumber == 1 && leftOne.active == false)
            {
                leftOne.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 2 && leftTwo.active == false)
            {
                leftTwo.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 3 && leftThree.active == false)
            {
                leftThree.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 4 && leftFour.active == false)
            {
                leftFour.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 5 && leftFive.active == false)
            {
                leftFive.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 6 && leftSix.active == false)
            {
                leftSix.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 7 && leftSeven.active == false)
            {
                leftSeven.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 8 && rightOne.active == false)
            {
                rightOne.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 9 && rightTwo.active == false)
            {
                rightTwo.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 10 && rightThree.active == false)
            {
                rightThree.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 11 && rightFour.active == false)
            {
                rightFour.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 12 && rightFive.active == false)
            {
                rightFive.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 13 && rightSix.active == false)
            {
                rightSix.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

            if (randomNumber == 14 && rightSeven.active == false)
            {
                rightSeven.SetActive(true);
                Count += 1;
                chooseBarricades();
            }
            else
            {
                chooseBarricades();
            }

        }

    }
	
}
