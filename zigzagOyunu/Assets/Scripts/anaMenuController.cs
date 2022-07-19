using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class anaMenuController : MonoBehaviour
{
    public void Oyna()
    {
        SceneManager.LoadScene(2);
    }

    public void Bolumler(){
        SceneManager.LoadScene(1);
    }

    public void Cikis()
    {
        Application.Quit();
    }
}
