using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class createNextPlatform : MonoBehaviour {

    private float x, y, z;
    [SerializeField]
    private GameObject prefab;

    void OnTriggerEnter(Collider other)
    {
        //Debug.Log(transform.position.x);
        Instantiate (prefab, new Vector3(transform.position.x + 80, 0, 0), Quaternion.identity);
        Destroy(this.gameObject);
    }
}
