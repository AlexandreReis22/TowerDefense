using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InicioGame : MonoBehaviour
{
    public void iniciar()
    {
        SceneManager.LoadScene(1);
    }
    public void sair()
    {
        Application.Quit();
    }
}
