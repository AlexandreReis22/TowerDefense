
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class tiro1 : MonoBehaviour
{
    public float _speed;
    public Collider2D _alvo;
    public bool _fAlvo;
    public LayerMask _layerInimigo;
    public BaseTorre _dano;

    void Update()
    {
        if(_alvo == null && !_fAlvo)
        {            
            _alvo = Physics2D.OverlapCircle(transform.position, 2f, _layerInimigo);
            _fAlvo = true;
        } else if (_alvo == null)
        {
            Destroy(gameObject);
        }
        Vector2 dir = (_alvo.gameObject.transform.position - transform.position).normalized;
        transform.Translate(dir *  _speed * Time.deltaTime);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(_dano == null)
        {
            _dano = collision.gameObject.GetComponent<BaseTorre>();
        }
        if (collision.gameObject.CompareTag("inimigo"))
        {
            inimigoBase inimigo = collision.gameObject.GetComponent<inimigoBase>();
            inimigo._vida -= _dano._dano;
            Destroy(gameObject);
        }
    }
}
