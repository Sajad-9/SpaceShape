using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{   

    void Start()
    {
        StartCoroutine(_Harder1());
        StartCoroutine(_Harder2());
        StartCoroutine(_Harder3());

    }


    void Update()
    {
    

    }

    IEnumerator _Harder1()
    {
        yield return new WaitForSeconds(30);
        Time.timeScale += 0.2f;
        Debug.Log("1");
    }

    IEnumerator _Harder2()
    {
        yield return new WaitForSeconds(60);
        Time.timeScale += 0.3f;
        Debug.Log("2");
    }

    IEnumerator _Harder3()
    {
        yield return new WaitForSeconds(100);
        Time.timeScale += 0.4f;
        Debug.Log("3");
    }

}
