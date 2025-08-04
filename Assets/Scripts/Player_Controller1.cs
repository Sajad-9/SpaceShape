using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Sprites;

public class Player_Controller1 : MonoBehaviour
{
    const string ScoreManager = "ScoreManager", HorizontalAxisName = "Horizontal", VerticalAxisName = "Vertical", _StartPos = "Start_Pos", _Top_Right = "Top_Right", _Bottom_Left = "Bottom_Left";
    const string _Circle = "Circle", _Diamond = "Diamond", _Square = "Square", _Life = "Life", BlackL = "Black_life";
    const string _Player_circle = "Player_circle", _Player_Diamond = "Player_diamond", _Player_Square = "Player_square";
    Rigidbody2D _RB;
    SpriteRenderer _Spp;
    [SerializeField] float _Speed;
    [SerializeField] Sprite[] _Newsprites;
    [SerializeField] GameObject[] _NewShapes;
    //using other class for updating score
    public Score Sc;
    public Soundmanager Sound;



    private void Start()
    {
        _RB = GetComponent<Rigidbody2D>();
        _Spp = GetComponent<SpriteRenderer>();
        float H = Random.value, S = 100, V = 90;
        _Spp.color = Color.HSVToRGB(H, S, V);
        Sc = GameObject.Find(ScoreManager).GetComponent<Score>();
        Sound = GameObject.Find("Soundmanager").GetComponent<Soundmanager>();
        //transform.position = GameObject.Find(_StartPos).transform.position;
        //_NewShapes = GetComponent<GameObject[]>();





    }

    private void Update()
    {
        Vector2 _Move = new Vector2(Input.GetAxis(HorizontalAxisName) * _Speed, Input.GetAxis(VerticalAxisName) * _Speed);
        _RB.velocity = _Move;


        #region movement limitation
        if (transform.position.x > GameObject.Find(_Top_Right).transform.position.x)
        {

            transform.position = new Vector2(GameObject.Find(_Top_Right).transform.position.x, transform.position.y);
        }
        else if (transform.position.x < GameObject.Find(_Bottom_Left).transform.position.x)
        {

            transform.position = new Vector2(GameObject.Find(_Bottom_Left).transform.position.x, transform.position.y);
        }

        if (transform.position.y > GameObject.Find(_Top_Right).transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, GameObject.Find(_Top_Right).transform.position.y);
        }
        else if (transform.position.y < GameObject.Find(_Bottom_Left).transform.position.y)
        {
            transform.position = new Vector2(transform.position.x, GameObject.Find(_Bottom_Left).transform.position.y);
        }


        #endregion



    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        if (other.gameObject.tag == _Circle)
        {
            if (gameObject.tag == _Player_circle)
            {
                Sc.AddScore();
                
            }
            else
            {
                Sc._DeleteLife();
                Sound._Error();
            }
            int ran = Random.Range(0, 3);
            bool _canmake = true;
            if (_canmake)
            {
                Instantiate(_NewShapes[ran], new Vector2(transform.position.x, transform.position.y - 0.05f), Quaternion.identity);
                _canmake = false;
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


        if (other.gameObject.tag == _Square)
        {
            if (gameObject.tag == _Player_Square)
            {
                Sc.AddScore();
                
            }
            else
            {
                Sc._DeleteLife();
                Sound._Error();
            }
            int ran = Random.Range(0, 3);
            bool _canmake = true;
            if (_canmake)
            {
                Instantiate(_NewShapes[ran], new Vector2(transform.position.x, transform.position.y - 0.05f), Quaternion.identity);
                _canmake = false;
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


        if (other.gameObject.tag == _Diamond)
        {
            if (this.gameObject.tag == _Player_Diamond)
            {
                Sc.AddScore();
                
            }
            else
            {
                Sc._DeleteLife();
                Sound._Error();
            }
            int ran = Random.Range(0, 3);
            bool _canmake = true;
            if (_canmake)
            {
                Instantiate(_NewShapes[ran], new Vector2(transform.position.x, transform.position.y - 0.05f), Quaternion.identity);
                _canmake = false;
            }
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }


        if (other.gameObject.tag == _Life)
        {
            Sc._AddLife();
            Sound._Life();
            Destroy(other.gameObject);  
        }

        if(other.gameObject.tag == BlackL)
        {
            Sound._Error();
            Sc._DeleteLife();
            Sc._DeleteLife();
            Destroy(other.gameObject);
        }

    }



}
