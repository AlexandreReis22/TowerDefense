using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Geral : MonoBehaviour
{
    public Vector3        _posMouse;
    public static int     _vida;
    public static int     _ouro;
    public static bool    _wave;
    public static bool    _ativarSpeedGame;
    public static int     _gameSpeed;    
    
    void Start()
    {
        pause._paused = false;
        Time.timeScale = 1;
        _ouro = 300;
        _vida = 10;
        _wave = false;
    }

    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        {
            WaveManager._wave++;
        }

        Time.timeScale = _gameSpeed;
              
        if(_vida > 0)
        {
            if (_ativarSpeedGame)
            {
                _gameSpeed = 2;
            }
            else if (!pause._paused)
            {
                _gameSpeed = 1;
            }
        }
        else
        {
            _gameSpeed = 0;
        }
        
        
        baseMouse();        
    }

    void baseMouse()
    {
        Vector3 Mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Mouse.z = 0;
        Vector2 Mouse2D = new Vector2(Mouse.x, Mouse.y);
        _posMouse = Mouse2D;
    }
    public void duasVezes()
    {
        _ativarSpeedGame = !_ativarSpeedGame;
    }
    public static void ganhoGold()
    {
        _ouro += 5;
    }
}

