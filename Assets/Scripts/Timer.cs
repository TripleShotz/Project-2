using UnityEngine;
 using System.Collections;
 using UnityEngine.UI;
 using UnityEngine.SceneManagement;
 
 public class SimpleTimer: MonoBehaviour {
 
 public float targetTime = 10.0f;
 
 void Update(){
 
 targetTime -= Time.deltaTime;
 
 if (targetTime <= 0.0f)
 {
    timerEnded();
 }
 
 }
 
 void timerEnded()
 {
    SceneManager.LoadScene(0);
 }
 
 }
