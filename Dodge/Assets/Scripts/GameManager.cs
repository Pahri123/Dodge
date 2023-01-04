using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject panelGameOver;
    public FinishState finishState;
    public Scorer scorer;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeElapsed;
    public bool timeElapsedcheck;
    public float finalTime;
    void Start()
    {
        timeElapsedcheck = false;
        panelGameOver.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
       if(finishState.isGameOver == true){
            panelGameOver.SetActive(true);
            scoreText.text = scorer.hits.ToString();
            if(timeElapsedcheck == false){
                timeElapsedcheck = true;
                finalTime = Time.timeSinceLevelLoad;
                timeElapsed.text = finalTime.ToString("0.0");
            }
        }   
    }

}
