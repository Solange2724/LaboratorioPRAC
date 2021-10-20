using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour{
    
    public static int ValPuntos = 0;
    Text PunTos;

    // Start is called before the first frame update
    void Start(){
        PunTos = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update(){
        PunTos.text = "Puntos : " + ValPuntos;
    }
}


