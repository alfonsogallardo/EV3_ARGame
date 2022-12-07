using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    

    public float moveSpeed=10f;
    public float turnSpeed=50f;

    private bool adelante;
    private bool atras;
    private bool derecha;
    private bool izquierda;
    private bool rotDerecha;
    private bool rotIZquierda;

    public Text nombre;
    public GameObject player;

    private void Start()
    {
        nombre.text = PlayerPrefs.GetString("nombre");
    }

    void Update()
    {
        if (adelante == true)
        {
            player.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (atras == true)
        {
            player.transform.Translate(-Vector3.forward * moveSpeed * Time.deltaTime);
        }

        if (derecha == true)
        {
            player.transform.Translate(Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (izquierda == true)
        {
            player.transform.Translate(-Vector3.right * moveSpeed * Time.deltaTime);
        }

        if (rotDerecha == true)
        {
            player.transform.Rotate(Vector3.up * turnSpeed * Time.deltaTime);
        }

        if (rotIZquierda == true)
        {
            player.transform.Rotate(-Vector3.up * turnSpeed * Time.deltaTime);
        }
    }

    public void HaciaAdelante()
    {
        adelante = true;
    }
    public void HaciaAtras()
    {
        atras = true;
    }

    public void HaciaIzquierda()
    {
        izquierda = true;
    }
    public void HaciaDerecha()
    {
        derecha = true;
    }

    public void RotacionDerecha()
    {
        rotDerecha = true;
    }

    public void RotacionIzquierda()
    {
        rotIZquierda = true;
    }

    public void sinFuncion()
    {
        adelante = false;
        atras = false;
        derecha = false;
        izquierda = false;
        rotDerecha = false;
        rotIZquierda = false;
    }


}