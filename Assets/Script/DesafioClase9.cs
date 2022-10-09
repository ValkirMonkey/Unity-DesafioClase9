using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DesafioClase9 : MonoBehaviour
{
    [SerializeField] Transform position;
    [SerializeField] Transform rotation;



    // Start is called before the first frame update
    void Start()

    {
        var pos = transform.position;
        Debug.Log("Posicion: " + pos);

        var ang = transform.rotation.eulerAngles;
        //transform.rotation = Quaternion.Euler(angles);
        Debug.Log("Rotacion: " + ang);

        var sca = transform.localScale;
        Debug.Log("Escala: " + sca);

    }

    
    float x;
    


    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0.05f, 0.0f, 0.0f);
        //transform.position = new Vector3(-0.05f, 0.0f, 0.0f);

        //transform.position = new Vector3(0.0f, 0.1f, 0.0f);
        //transform.position = new Vector3(0.0f, -0.1f, 0.0f);

        //transform.position = new Vector3(0.0f, 0.0f, 0.25f);
        //transform.position = new Vector3(0.0f, 0.0f, -0.25f);

        //Rotacion sin detenerse Eje X
        //x += Time.deltaTime * 15;
        //transform.rotation = Quaternion.Euler(x, 0, 0);

        //Rotacion sin detenerse Eje Y
        //x += Time.deltaTime * 30;
        //transform.rotation = Quaternion.Euler(0, x, 0);

        //Rotacion sin detenerse Eje Z
        //x += Time.deltaTime * 60;
        //transform.rotation = Quaternion.Euler(0, 0, x);

        //transform.localScale = new Vector3(2.0f, 1.0f, 1.0f);
        //transform.localScale = new Vector3(1.0f, 3.0f, 1.0f);
        //transform.localScale = new Vector3(1.0f, 1.0f, 5.0f);

    }
}
