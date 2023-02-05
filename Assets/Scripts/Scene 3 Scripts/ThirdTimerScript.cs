using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.ComponentModel.Design;

public class ThirdTimerScript : MonoBehaviour
{
    //get other scripts
    ThirdPuzScript thirdPuzzleScript;
    public GameObject puzzleContainer;

    //timer variables
    public Slider timerSlider;
    public TextMeshProUGUI timerText;
    public float gameTime;
    public GameObject TimerCanvas;

    private bool stopTimer;

    float timer = 00f;

    // Start is called before the first frame update
    void Start()
    {
        thirdPuzzleScript = puzzleContainer.GetComponent<ThirdPuzScript>();

        stopTimer = false;
        timerSlider.maxValue = gameTime;
        timerSlider.value = gameTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (thirdPuzzleScript.completionCounterlvl3 == 4)
        {
            TimerCanvas.SetActive(true);

            timer += Time.deltaTime;
            float time = gameTime - timer;

            int minutes = Mathf.FloorToInt(time / 60);
            int seconds = Mathf.FloorToInt(time - minutes * 60f);

            string textTime = string.Format("{00}", seconds);

            if (time <= 0)
            {
                stopTimer = true;
                TimerCanvas.SetActive(false);

                //reset scene
                SceneManager.LoadScene("Level 3");
            }
            if (stopTimer == false)
            {
                timerText.text = textTime;
                timerSlider.value = time;
            }
        }
        else
        {
            TimerCanvas.SetActive(false);
        }
    }
}
