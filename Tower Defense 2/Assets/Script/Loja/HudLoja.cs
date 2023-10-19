using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HudLoja : MonoBehaviour
{
    [SerializeField]
    private loja _loja;
    private int _id;
    public static bool _comprou;

    public void CompraTorre(string name)
    {
        if (_loja._towerName.ContainsKey(name) && Geral._ouro >= _loja._towerName[name] && !_comprou)
        {
            Instantiate(_loja.torres[_id], _loja.botoes[_id].transform.position, Quaternion.identity);
            Geral._ouro -= _loja._towerName[name];
            _comprou = true;
        }        
    }
    public void selectId(int id)
    {
        _id = id;
    }
}
