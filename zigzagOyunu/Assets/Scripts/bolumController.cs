using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolumController : MonoBehaviour
{
    public void Bolum1()
    {
        SceneManager.LoadScene(2);
    }

    public void Bolum2()
    {
        int bolum = PlayerPrefs.GetInt("bitirilenBolum");
        if (bolum == 1)
        {
            SceneManager.LoadScene(3);
        }
    }
}
