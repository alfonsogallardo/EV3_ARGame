using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public InputField input;
    public string escena;

    public void setNombre()
    {
        string n = input.text;
        if (string.IsNullOrEmpty(n))
        {
            Debug.Log("Valor Nulo");
        }
        else
        {
            Debug.Log("El nombre es: " + n);
            PlayerPrefs.SetString("nombre", n);
            SceneManager.LoadScene(escena);
        }
    }
}
