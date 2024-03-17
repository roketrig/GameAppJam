using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Can : MonoBehaviour
{
    [SerializeField] List<GameObject> list = new List<GameObject>();
    private int candegeri = 3;
    private bool end = false;
    private int indexal = 0;
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("dusman"))
        {
            Destroy(other.gameObject);
            candegeri--;
        }
        else if (candegeri == 0)
        {
            end = true;
        }
        else if (other.CompareTag("dusman"))
        {
            Destroy(list[candegeri].gameObject);
        }
    }
}
