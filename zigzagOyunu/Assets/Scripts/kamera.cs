using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public Transform topKonum;
    Vector3 fark;

    void Start()
    {
        fark = transform.position - topKonum.position;
    }

    void Update()
    {
        if (topController.dustu == false)
        {
            transform.position = topKonum.position + fark;
        }
    }
}

