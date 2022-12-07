using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class click : MonoBehaviour
{
    public string menu;
    public void victoria()
    {
        SceneManager.LoadScene(menu);
    }
}
