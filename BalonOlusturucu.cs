using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalonOlusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 0.5f;
    float timer = 0f;
    oyunKontrolcu oyunKontrolcuScript;


    void Start()
    {
        oyunKontrolcuScript = this.gameObject.GetComponent<oyunKontrolcu>();
    }

    void Update()
    {
        timer-=Time.deltaTime;
        int katsayi = (int)(oyunKontrolcuScript.zamansayaci / 10) - 6;
        katsayi *= -1;
        if(timer < 0 && oyunKontrolcuScript.zamansayaci >0)
        {
            GameObject go = Instantiate(balon,new Vector3(Random.Range(-2.55f,2.55f),-6f,0),Quaternion.Euler(0,0,0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3 (0,Random.Range(30f*katsayi,80f*katsayi),0));
            timer = balonOlusturmaSuresi;
        }
    }
}
