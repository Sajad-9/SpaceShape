using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Score : MonoBehaviour
{
    public Text _Scoretext;
    public Text _HighScoretext;
    public float _Score, _Highscore;
    public Image[] _AddLives;
    public Image _Life;
    public int _LivesCount = 0;


    private void Start()
    {
           

    }
    public void AddScore()
    {
        _Score++;
    }


    private void Update()
    {
        
        //Time.timeScale += (Time.time / 100) * Time.deltaTime;
        //------------------------
        _Highscore = PlayerPrefs.GetFloat("Highscore");
        _Scoretext.text = "Score : " + _Score.ToString();
        _HighScoretext.text = "HighScore : " + _Highscore.ToString();
        if (_Score > _Highscore)
        {
            PlayerPrefs.SetFloat("Highscore", _Score);

        }

    }

    public static void _DeletAllScore()
    {
        PlayerPrefs.DeleteAll();
    }

    public void _DeleteLife()
    {
        if (_LivesCount == 0)
        {
            _AddLives[0].GetComponent<Image>().enabled = false;
            _LivesCount++;
            
        }

        else if (_LivesCount == 1)
        {
            _AddLives[1].GetComponent<Image>().enabled = false;
            _LivesCount++;
        }

        else if (_LivesCount == 2)
        {
            _AddLives[2].GetComponent<Image>().enabled = false;
            _LivesCount++;
        }
        if (_LivesCount == 3)
        {
            SceneManager.LoadScene(2);
        }
    }

    public void _AddLife()
    {
        if (_LivesCount == 2)
        {
            _AddLives[1].GetComponent<Image>().enabled = true;
            _LivesCount--;
            
            
        }

        else if (_LivesCount == 1)
        {
            _AddLives[0].GetComponent<Image>().enabled = true;
            _LivesCount--;
            
        }

    }

    public float SetStaticScore(float input)
    {
        input = _Highscore;
        return input;
    }
}
