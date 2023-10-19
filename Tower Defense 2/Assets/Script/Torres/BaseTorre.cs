using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseTorre : MonoBehaviour
{
    [Header("ataque")]
    public int _dano;
    public bool _ataque = true;
    public float _nextAtk;
    public float _rangeAtk;
    public bool _atirarArea;
    public LayerMask _layerAtaque;
    public GameObject _rangeObj;

    [Header("Tiro")]
    public GameObject _tiro;   

    [Header("Level")]
    public int _nivel;

    [Header("Spawns")]
    public bool _spawm;
    public bool _spawnBlockLocal;
    public Transform[] _spawmTiro;
    public LayerMask _blockSpawm;

    [Header("outra Torre")]
    public bool _OtherTorre;

    [Header("Strings")]
    public Text _TextDanoUp;
    public Text _TextSpeedUp;

    public AudioSource _audioTiro;
   
}
