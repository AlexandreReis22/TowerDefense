using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loja : MonoBehaviour
{
    public GameObject[] torres;
    public GameObject[] botoes;
 
    public Dictionary<string, int> _towerName = new Dictionary<string, int>
    {
        {"torre1", 270},
        {"torre2", 430},        
    };
}
