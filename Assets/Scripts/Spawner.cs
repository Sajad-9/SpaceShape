using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    const string _Right = "Top_Right", _Left = "Bottom_Left";

    [SerializeField] GameObject[] _Objects;
    [SerializeField] GameObject _life;
    [SerializeField] GameObject _Blacklife;
    [SerializeField] float _SpawnInterval;
    [SerializeField] float _LifeInterval;
    [SerializeField] float _BlackLifeInterval;
    [SerializeField] float _RotationRange = 90f;
    [SerializeField] bool _CanSpawn = true;
    [SerializeField] bool _LifeCanSpawn = false;
    [SerializeField] bool _BlackLifeCanSpawn = false;

    private void Start()
    {
        StartCoroutine(LifeSpawnInterval());
        StartCoroutine(BlackLifeSpawnInterval());
    }

    void Update()
    {
        int _input = Random.Range(0, _Objects.Length);
        #region Spawn
        if (_CanSpawn)
        {
            float RandX = Random.Range(GameObject.Find(_Right).transform.position.x, GameObject.Find(_Left).transform.position.x);
            float RandRotation = Random.Range(-_RotationRange, _RotationRange);
            Instantiate(_Objects[_input], new Vector3(RandX, transform.position.y), Quaternion.Euler(0f, 0f, RandRotation));
            _CanSpawn = false;
            StartCoroutine(Spawninterval());

        }

        if (_LifeCanSpawn)
        {
            Instantiate(_life, new Vector3(Random.Range(GameObject.Find(_Right).transform.position.x, GameObject.Find(_Left).transform.position.x), transform.position.y, 0), Quaternion.identity);
            _LifeCanSpawn = false;
            StartCoroutine(LifeSpawnInterval());

        }

        if (_BlackLifeCanSpawn)
        {
            Instantiate(_Blacklife, new Vector3(Random.Range(GameObject.Find(_Right).transform.position.x, GameObject.Find(_Left).transform.position.x), transform.position.y, 0), Quaternion.identity);
            _BlackLifeCanSpawn = false;
            StartCoroutine(BlackLifeSpawnInterval());

        }
        #endregion



    }

    IEnumerator Spawninterval()
    {
        yield return new WaitForSeconds(_SpawnInterval);
        _CanSpawn = true;
    }

    IEnumerator LifeSpawnInterval()
    {
        yield return new WaitForSeconds(_LifeInterval);
        _LifeCanSpawn = true;
    }

    IEnumerator BlackLifeSpawnInterval()
    {
        yield return new WaitForSeconds(_BlackLifeInterval);
        _BlackLifeCanSpawn = true;
    }
}
