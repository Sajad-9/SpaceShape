using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGame_Manager : MonoBehaviour
{


    public Text _Hscore_Text;
    public float _HScore;

    private void Start()
    {
        Time.timeScale = 1;
    }
    void Update()
    {
        _Hscore_Text.text = "High Score : " + Bifrost._HS.ToString();
    }

    public void GotoMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
    }


}
