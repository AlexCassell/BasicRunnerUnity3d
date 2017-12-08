using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class theEnd : MonoBehaviour
{

    [SerializeField]
    public static int speed = 1;
    [SerializeField]
    private int speedIncrease = 1;


    void Start()
    {
        StartCoroutine(IncreaseSpeed());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    IEnumerator IncreaseSpeed()
    {
        yield return new WaitForSeconds(10);
        speed += speedIncrease;
        Debug.Log(speed);
        StartCoroutine(IncreaseSpeed());
    }
}
