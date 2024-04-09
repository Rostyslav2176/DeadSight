using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KillCount : MonoBehaviour
{
    public Text counterText;
    int kills;

    private void Update()
    {
        ShowKills();
        GameOver();
    }

    public void GameOver()
    {
        if(kills >= 6)
        {
            SceneManager.LoadScene(2);
        }
    }
    public void AddKill()
    {
        kills++;
    }

    public void ShowKills()
    {
        counterText.text = kills.ToString();
    }
}
