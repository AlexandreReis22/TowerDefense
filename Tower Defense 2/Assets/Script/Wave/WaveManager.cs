using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[]  _objInim;   
    [SerializeField]
    private Transform    _spawmInim;
    public static int    _wave;
    [SerializeField]
    private float        _timeSpawn;
    public int     _nSpawm;
    public static int    _nextWave;
    private bool _spawm = true;

    void Start()
    {
        _wave = 1;
    }
       
    void Update()
    {
        if (Geral._wave)
        {            
            if (_nSpawm < 10 * _wave && _spawm)
            {
                _spawm = false;
                StartCoroutine(SpawmWave());
                
            }
            else if(_nextWave == 10 * _wave) 
            {
                Geral._wave = false;
                Geral._ouro += 250;
                _wave++;                
                _nextWave = 0;
                _nSpawm = 0;
            }
        }

       IEnumerator SpawmWave()
       {
            yield return new WaitForSeconds(_timeSpawn);
            Spawm();
            _spawm = true;
       }
    }
    void Spawm()
    {
        Instantiate(_objInim[0], _spawmInim.position, quaternion.identity);

        _nSpawm++;
    }    
}
