using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Sayac : MonoBehaviour
{
    public TMP_Text sayac_text;
    public int sayac_max = 100;
    private float ilerleyenzaman =0 ;
    private bool end;

    void Update()
    {
        if (!end)
        {
            ilerleyenzaman+= Time.deltaTime;

            sayac_text.text = Mathf.RoundToInt(ilerleyenzaman).ToString();

            if (ilerleyenzaman >= sayac_max)
            {
                GameOver();
            }
        }
        if (sayac_max == 100)
        {
            //SceneManager.LoadScene();
        }
    }
    void GameOver()
    {
        Time.timeScale= 0;
        end = true;
    }
}
