using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bifrost : MonoBehaviour
{

    public static float _HS;
    public Score _S;

    private void Start()
    {
        _S = GetComponent<Score>();
        
    }

    private void Update()
    {
        _HS = _S.SetStaticScore(_HS);
        
    }

}
