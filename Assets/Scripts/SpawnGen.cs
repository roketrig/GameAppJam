using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnGen : MonoBehaviour
{
    public List<GameObject> spawnpoint = new List<GameObject>();
    private GameObject selectSpawn;
    float rastgelearalik;
    public float spawnSaniye = 1f;
    private float sayac = 0f;
    private Quaternion rotasyon;

    void Update()
    {
        sayac += Time.deltaTime;
        if (sayac >= spawnSaniye)
        {
            float rastgelearalik = Random.Range(-6f, 6f);
            int rastgele = Random.Range(0, spawnpoint.Count);
            selectSpawn = spawnpoint[rastgele];
            Vector3 yeniPos = new Vector3(rastgelearalik, transform.position.y, transform.position.z * Time.deltaTime *5);
            Instantiate(selectSpawn, yeniPos, Quaternion.identity);
            sayac = 0f;
        }

    }
}
