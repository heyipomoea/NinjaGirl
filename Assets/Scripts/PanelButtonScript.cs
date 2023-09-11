using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelButtonScript : MonoBehaviour
{
    public GameObject selectPanel, stopButton;

    public void setSelectPanelOn()
    {
        selectPanel.SetActive(true);
        Time.timeScale = 0f;
    }

    public void setSelectPanelOff()
    {
        selectPanel.SetActive(false);
        Time.timeScale = 1.0f;
    }

    public void SetStopButtonOn()
    {
        stopButton.SetActive(true);
    }

    public void SetStopButtonOff()
    {
        stopButton.SetActive(false);
    }

    public void MainMenuPlayButton()
    {
        GameObject mainMenuPlayer = GameObject.Find("MainMenuPlayer");
        Animator myAnim = mainMenuPlayer.GetComponent<Animator>();
        myAnim.SetBool("Run", true);

        GameObject playButton = GameObject.Find("Canvas/SafeAreaPanel/PlayButton");
        playButton.SetActive(false);
    }
}
