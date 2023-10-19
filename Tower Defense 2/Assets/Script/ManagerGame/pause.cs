using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pause : MonoBehaviour
{
    public GameObject _hudPause;
    public static bool _paused;

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            _paused = !_paused;
        }
        if(_paused) 
        {
            _hudPause.SetActive(true);
            Geral._ativarSpeedGame = false;
            Time.timeScale = 0; 
        } 
        else
        {
            _hudPause.SetActive(false);
            Time.timeScale = Geral._gameSpeed;
        }
    }
    public void retornar()
    {
        _paused = false;
    }
    public void restartFase()
    {        
        SceneManager.LoadScene(1);
    }
}
