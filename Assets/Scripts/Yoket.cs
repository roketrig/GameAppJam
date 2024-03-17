using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yoket : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("dusman"))
        {
            Destroy(other.gameObject);
        }
    }
}
