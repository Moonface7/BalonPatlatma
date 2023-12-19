using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balonKontrol : MonoBehaviour
{
    public GameObject patlama;
    oyunKontrolcu oyunKontrolcuScript;

    private void Start()
    {
        oyunKontrolcuScript = GameObject.Find("_Scripts").GetComponent<oyunKontrolcu>();
    }

    private void OnMouseDown()
    {
        GameObject go = Instantiate(patlama,transform.position,transform.rotation) as GameObject;
        Destroy(this.gameObject);
        Destroy(go,0.333f);
        oyunKontrolcuScript.balonEkle();
    }

}

