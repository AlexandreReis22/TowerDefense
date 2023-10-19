using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hud : MonoBehaviour
{
    public Text[] _hud;
   
    void Update()
    {
        _hud[0].text = Geral._vida.ToString();
        _hud[1].text = Geral._ouro.ToString();
        _hud[2].text = WaveManager._wave.ToString();
        if(Geral._vida <= 0)
        {
            _hud[0].text = "0";
        }
    }
    public void iniciarWave()
    {
        Geral._wave = true;
    }
}
