using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Attack : MonoBehaviour
{
    public Animator yasou;
    public Transform yasoukontrol;
    public int hiz;
    void Start()
    {
        
    }

    void Update()
    {
        float hareket = Input.GetAxis("Horizontal")*Time.deltaTime*hiz;
        yasoukontrol.Translate(hareket,0f,0f);
        if(hareket != 0f){
            yasou.SetTrigger("Yuru");
        }

        if(Input.GetKeyDown(KeyCode.E)){
            yasou.SetTrigger("Saldir");
        }
        
    }
}