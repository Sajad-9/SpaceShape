using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Spawner : MonoBehaviour
{
    [SerializeField] float ypos;
    [SerializeField] float _LifeInterval;


    void Update()
    {
        transform.Translate( new Vector2(0, ypos) * Time.deltaTime);
        StartCoroutine(_LifeDestroy());
    }

    
    IEnumerator _LifeDestroy()
    {
        yield return new WaitForSeconds(_LifeInterval);
        Destroy(gameObject);
    }
}
