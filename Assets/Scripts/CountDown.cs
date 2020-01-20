using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;
 
public class CountDown : MonoBehaviour
{
    float timeLeft = 1800.0f;
     
    public Text text;
    public GameManager gameManager;
     
 
     
    void Update()
    {
        if (gameManager.isGameActive)
        {
            timeLeft -= Time.deltaTime;
            text.text = "Time Left:" + Mathf.Round(timeLeft);
            if(timeLeft < 0)
            {
                gameManager.GameOver();
            }   
        }
    }
}
