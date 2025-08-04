using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Menu : MonoBehaviour
{

    [SerializeField] GameObject[] _Objects;
    const string _Right = "TopR", _Left = "TopL";
    [SerializeField] float _SpawnInterval;
    [SerializeField] bool _CanSpawn = true;




    void Update()
    {
        int _input = Random.Range(0, 3);
        
        if (_CanSpawn)
        {
            Instantiate(_Objects[_input], new Vector3(Random.Range(GameObject.Find(_Right).transform.position.x, GameObject.Find(_Left).transform.position.x), transform.position.y, 0), Quaternion.identity);
            _CanSpawn = false;
            StartCoroutine(Spawninterval());

        }
    }
    IEnumerator Spawninterval()
    {
        yield return new WaitForSeconds(_SpawnInterval);
        _CanSpawn = true;
    }
}

