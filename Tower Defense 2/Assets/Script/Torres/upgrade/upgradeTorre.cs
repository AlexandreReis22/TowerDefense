using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class upgradeTorre : MonoBehaviour
{
    [SerializeField]
    private BaseTorre _base;
    public int _nivelTorre;
    public GameObject _hudUp;
    public SpriteRenderer[] _objNivel;
 
    private void Start()
    {
        _base = GetComponentInParent<BaseTorre>();
    }
    public void UpDano()
    {

        if (Geral._ouro >= (100 * _nivelTorre) && _nivelTorre < 4)
        {
            _base._dano++;
            Geral._ouro -= 100 * _nivelTorre;
            _objNivel[_nivelTorre - 1].color = Color.white;
            _nivelTorre++;            
            _hudUp.SetActive(false);
        }
    }
    public void UpAtkSpeed()
    {        
        if (Geral._ouro >= (150 * _nivelTorre) && _nivelTorre < 4)
        {
            _base._nextAtk -= 0.14f;
            Geral._ouro -= 150 * _nivelTorre;         
            _objNivel[_nivelTorre - 1].color = Color.white;
            _nivelTorre++;
            _hudUp.SetActive(false);

        }
    }    
    private void OnMouseExit()
    {
        _hudUp.SetActive(false);   
    }
}
