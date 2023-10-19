using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inimigoComum : MonoBehaviour
{
    private inimigoBase _base;    

    void Awake()
    {
        _base = GetComponent<inimigoBase>();
        _base._vida = 1;
    }
    private void Start()
    {
        if (WaveManager._wave > 1 )
        {
            _base._vida = Random.Range(1, (2 + WaveManager._wave));
        }        
        velocidade();
    }
    void Update()
    {        
        if( _base._vida > 0)
        {
            _base._sprites.color = _base.cor[_base._vida - 1];
        }     
        
        if (_base._vida <= 0 && !_base._morreu)
        {            
            _base._morreu = true;
            _base._audioMorte.Play();
            Invoke("morte", 0.1f);            
            Geral.ganhoGold();
            WaveManager._nextWave++;            
        }        
    }
    private void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, rotaMap._FixedRota[_base._nRota].position, _base._vel[_base._velAtual] * Time.deltaTime);
    }
    void morte()
    {
        Destroy(gameObject);
    }
    void velocidade()
    {
        if (WaveManager._wave > 4)
        {
            _base._velAtual = Random.Range(1, 4);
        }
        else
        {
            _base._velAtual = 0;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("curva"))
        {
            _base._nRota++;
        } 
        else if (collision.gameObject.CompareTag("Player"))
        {
            WaveManager._nextWave++;
            Geral._vida -= _base._vida;
            Destroy(gameObject);
        }
    }
}
