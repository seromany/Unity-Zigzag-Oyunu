using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zeminSpawner : MonoBehaviour
{
    public GameObject sonZemin;
    public GameObject elmas;

    void Start()
    {
        for (int i = 0; i < 20; i++)
        {
            zeminOlustur();
        }
    }

    public void zeminOlustur()
    {
        Vector3 yon;
        if (Random.Range(0, 2) == 0) yon = Vector3.left;
        else yon = Vector3.forward;
        sonZemin = Instantiate(sonZemin,sonZemin.transform.position + yon, sonZemin.transform.rotation);
        if(Random.Range(0,5) == 0)
        {
            Vector3 silindir = new Vector3(sonZemin.transform.position.x, 1, sonZemin.transform.position.z);
            Instantiate(elmas, silindir, sonZemin.transform.rotation);
        }
    }
}
