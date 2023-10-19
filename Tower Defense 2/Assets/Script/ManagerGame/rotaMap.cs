using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotaMap : MonoBehaviour
{
    public Transform[] _rota;
    public static Transform[] _FixedRota;

    private void Start()
    {
        _FixedRota = new Transform[_rota.Length];
        for (int i = 0; i < _rota.Length; i++)
        {
            _FixedRota[i] = _rota[i];
        }
    }
}
