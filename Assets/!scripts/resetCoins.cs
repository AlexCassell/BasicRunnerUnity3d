using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetCoins : MonoBehaviour {

    [SerializeField]
    private GameObject coinOne;
    [SerializeField]
    private GameObject coinTwo;
    [SerializeField]
    private GameObject coinThree;

    void Start () {
        coinOne.SetActive(true);
        coinTwo.SetActive(true);
        coinThree.SetActive(true);
    }

}
