using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Build;
using UnityEngine;
using UnityEngine.UI;

public class oyunKontrolcu : MonoBehaviour
{
    public Text zamanText, balonText;
    public float zamansayaci = 60f;
    public GameObject patlama;
    int balonsayaci = 0;

    void Start()
    {
        balonText.text = "Balon: " + balonsayaci;
    }

    void Update()
    {
        //zaman sayacý ile oyunu baslatma
        if (zamansayaci >0)
        {
            zamansayaci -= Time.deltaTime;
            zamanText.text = "Süre: " + (int)zamansayaci;
        }
        // süre bitince objeleri kaldýrma
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon");
            for(int i = 0; i < go.Length; i++) 
            {
                Destroy(go[i]);
                GameObject Patlama = Instantiate(patlama,go[i].transform.position, go[i].transform.rotation) as GameObject;
                Destroy(Patlama, 0.333f);                            
            }
        }
    }

    //balon ekleme
    public void balonEkle()
    {
        balonsayaci++;
        balonText.text = "Balon: " + balonsayaci;
    }  
}
