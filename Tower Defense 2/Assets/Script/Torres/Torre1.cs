using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torre1 : MonoBehaviour
{
    [SerializeField]
    private BaseTorre _base;
    [SerializeField]
    private upgradeTorre _baseUp;
    [SerializeField]
    private Geral _mouse;    

    void Awake()
    {
         gComponent();
        _base._spawm = false;
    }
    
    void Update()
    {
         gPhysics2D();
         gStrings();

        if (_base._spawm)
        {
            if (_base._atirarArea && _base._ataque)
            {
                ataque();
                _base._ataque = false;
                _base._audioTiro.Play();
                StartCoroutine(atirar(_base._nextAtk));
            }
        } 
        else
        {
            transform.position = _mouse._posMouse;
        }
    }
    IEnumerator atirar(float _time)
    {
        yield return new WaitForSeconds(_time);
        _base._ataque = true;
    }
    private void OnMouseDown()
    {
        if (_base._spawm)
        {
            _baseUp._hudUp.SetActive(true);
        }
        if (!_base._spawnBlockLocal && !_base._OtherTorre) 
        {
            _base._spawm = true;
            HudLoja._comprou = false;
        } 
        
    }
    private void OnMouseEnter()
    {
        _base._rangeObj.SetActive(true);
    }
    private void OnMouseExit()
    {
        _base._rangeObj.SetActive(false);        
    }
    void ataque()
    {
        Instantiate(_base._tiro, _base._spawmTiro[0].position, Quaternion.identity);        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("torre"))
        {            
            _base._OtherTorre = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("torre"))
        {            
            _base._OtherTorre = false;
        }
    }
    void gComponent()
    {
        _mouse = FindAnyObjectByType<Geral>();
        _base = GetComponent<BaseTorre>();
        _baseUp = GetComponentInChildren<upgradeTorre>(true);
    }
    void gStrings()
    {
        _base._TextDanoUp.text = (100 * _baseUp._nivelTorre).ToString();
        _base._TextSpeedUp.text = (150 * _baseUp._nivelTorre).ToString();
    }
    void gPhysics2D()
    {
        _base._atirarArea = Physics2D.CircleCast(transform.position, _base._rangeAtk, Vector2.zero, 0, _base._layerAtaque);
        _base._spawnBlockLocal = Physics2D.OverlapBox(transform.position, new Vector2(0.58f, 1.17f), 0, _base._blockSpawm);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 1.50f);
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position, new Vector2(0.58f, 1.17f));
    }    
}
