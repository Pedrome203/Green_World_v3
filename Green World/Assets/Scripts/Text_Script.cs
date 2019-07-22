using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Text_Script : MonoBehaviour
{
    Text miMensaje;
    public string mensaje;
    // Start is called before the first frame update

    void Awake()
    {
        miMensaje = GameObject.Find("Canvas/Panel/Text_Info").GetComponent<Text>();
    }
    public void MostrarMensaje()
    {
        miMensaje.text = mensaje;
    }
    public void quitarMensaje()
    {
        miMensaje.text = "";
    }
}
    // Update is called once per frame
