using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class coins : MonoBehaviour {

    private Color colorStart = Color.red;
    private Renderer rend;

    public int randomNumber;
    void Start ()
    {
        randomNumber = Random.Range(0, 3);
        if (randomNumber == 1) {
            rend = GetComponent<Renderer>();
            rend.material.color = colorStart;
        }

    }

    void OnTriggerEnter(Collider other)
    {
        if(randomNumber == 1)
        {
            theEnd.speed += 5;
        }
        else
        {
            theEnd.speed -= 1;

        }
        // Debug.Log(theEnd.speed);
        this.gameObject.SetActive(false);
    }

    void Update () {
        transform.Rotate(Vector3.up * 20 *Time.deltaTime);
        transform.Rotate(Vector3.right * 20 * Time.deltaTime);
    }
}
