using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vitoria : MonoBehaviour
{
    public GameObject _hudWin;

    void Update()
    {
        if(WaveManager._wave >= 10)
        {
            _hudWin.SetActive(true);            
        }
    }
    public void proxNivel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    
}
