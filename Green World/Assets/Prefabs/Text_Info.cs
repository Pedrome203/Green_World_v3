using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Text_Info : MonoBehaviour
{
    bool Mostrar = false;
    public string mensaje;

    Text miMensaje;
    void Awake()
    {
         miMensaje = GameObject.Find("Texto_Informativo/Panel").GetComponent(typeof(Text)) as Text;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (!Mostrar)
            {
                Mostrar = true;
                miMensaje.text = mensaje;
            }
            else if (Mostrar)
            {
                this.GetComponent<Text_Info>().enabled = false;
                Mostrar = false;
                miMensaje.text = "";

            }
        }
       
    }
    
}

