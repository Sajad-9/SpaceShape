using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainGameManager : MonoBehaviour
{
    public Text _HScore;
    public Text Intscore;
    private void Update()
    {
        _HScore.text = "Players Highest Score : ";
        Intscore.text = Bifrost._HS.ToString();
    }

    public void DelScore()
    {
        Score._DeletAllScore();
    }

    public void GotoGame()
    {
        SceneManager.LoadScene(1);
    }

}
