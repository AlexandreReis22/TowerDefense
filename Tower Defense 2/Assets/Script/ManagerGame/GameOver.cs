using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject _screenGameOver;
    
    void Update()
    {
        if(Geral._vida <= 0)
        {
             Time.timeScale = 0;
            _screenGameOver.SetActive(true);
            
        }
    }
    public void restart()
    {            
          SceneManager.LoadScene(SceneManager.GetActiveScene().name);                   
    }
}
