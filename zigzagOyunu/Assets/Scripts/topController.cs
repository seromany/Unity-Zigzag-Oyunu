using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class topController : MonoBehaviour
{
    Vector3 yon;
    public float hiz = 3;
    public zeminSpawner zeminSpawnerScript;
    public static bool dustu;
    
    public TextMesh puan;
    int puanDegeri = 0;

    void Start()
    {
        yon = Vector3.forward;
        dustu = false;
    }

    void Update()
    {
        if (transform.position.y <= 0.5f)
        {
            dustu = true;
        }
        if (Input.GetMouseButtonDown(0))
        {
            if (yon.x == 0)
            {
                yon = Vector3.left;
            }
            else
            {
                yon = Vector3.forward;
            }
        }
    }

    void FixedUpdate()
    {
        Vector3 hareket = yon * Time.deltaTime * hiz;
        transform.position += hareket;
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "zemin")
        {
            collision.gameObject.AddComponent<Rigidbody>();
            zeminSpawnerScript.zeminOlustur();
            StartCoroutine(zeminSil(collision.gameObject));
        }
    }

    IEnumerator zeminSil(GameObject obj)
    {
        yield return new WaitForSeconds(3f);
        Destroy(obj);
    }

    void OnTriggerExit(Collider obj)
    {
        if (obj.gameObject.tag == "silindir")
        {
            puanDegeri++;
            puan.text = puanDegeri.ToString();
            obj.gameObject.AddComponent<Rigidbody>();
            if (puanDegeri == 100 && PlayerPrefs.GetInt("bitirilenBolum") != 1)
            {
                PlayerPrefs.SetInt("bitirilenBolum", 1);
                SceneManager.LoadScene(3);
            }
            if (PlayerPrefs.GetInt("bitirilenBolum") == 1)
            {
                hiz += 0.5f;
                if (puanDegeri == 100)
                {
                    SceneManager.LoadScene(0);
                }
            }
        }
    }
}
