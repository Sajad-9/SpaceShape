using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class O_Move_Menu : MonoBehaviour
{
    [SerializeField] float x_speed, y_speed;
    [SerializeField] float _DestroyCooldown;
    const string _Point = "Point";
    bool _Changecolor = true;

    SpriteRenderer _SP;
    void Start()
    {
        
        _SP = GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        Vector2 _move = new Vector2(x_speed * Time.deltaTime, y_speed * Time.deltaTime);
        transform.Translate(_move);
        StartCoroutine(_Destroy());

        float H = Random.value, S = 100, V = 80;

        if (_Changecolor)
        {
            if (this.transform.position.y < GameObject.Find(_Point).transform.position.y)
            {
                _SP.color = Color.HSVToRGB(H, S, V);
                _Changecolor = false;
            }
        }

    }


    IEnumerator _Destroy()
    {
        yield return new WaitForSeconds(_DestroyCooldown);
        Destroy(this.gameObject);
    }


}
