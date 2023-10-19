using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiro2 : MonoBehaviour
{
    public float _speed;
    public BaseTorre _base;
    public float _timeDestroy;

    void Start()
    {

    }
    
    void Update()
    {
        if(_timeDestroy > 0.45f)
        {
            Destroy(gameObject);
        } else
        {
            _timeDestroy += Time.deltaTime;
        }
        transform.Translate((Vector2.up * _speed * Time.deltaTime), Space.Self);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (_base == null)
        {
            _base = collision.GetComponent<BaseTorre>();
        }
        if (collision.gameObject.CompareTag("inimigo"))
        {
            inimigoBase inimigo = collision.GetComponent<inimigoBase>();
            inimigo._vida -= _base._dano;
            Destroy(gameObject);
        }
    }
}
