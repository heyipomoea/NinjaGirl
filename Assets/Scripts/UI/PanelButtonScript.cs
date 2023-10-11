using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButtonScript : MonoBehaviour
{
    public GameObject selectPanel, stopButton, levelSelectButton, mainMenuButton, replayButton;

    public void ReplayButton()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        FadeInOut.instance.SceneFadeInOut(sceneName);
    }

    public void MainMenuButton()
    {
        //SceneManager.LoadScene("MainMenu");
        //Time.timeScale = 1.0f;
        FadeInOut.instance.SceneFadeInOut("MainMenu");
    }

    public void LevelSelectButton()
    {
        //SceneManager.LoadScene("LevelSelect");
        //Time.timeScale = 1.0f;
        FadeInOut.instance.SceneFadeInOut("LevelSelect");
    }

    public void NoButton()
    {
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, 1500f);
    }

    public void YesButton() 
    {
        PlayerPrefs.DeleteAll();
        IsFirstTimePlayCheck checkScript = GameObject.Find("IsFirstTimePlayCheck").GetComponent<IsFirstTimePlayCheck>();
        checkScript.FirstTimePlayState();
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, 1500f);
    }

    public void DataDeleteButton()
    {
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, -100f);
    }

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

        //StartCoroutine(LevelSelect());
        FadeInOut.instance.SceneFadeInOut("LevelSelect");
    }

    //private IEnumerator LevelSelect()
    //{
    //    yield return new WaitForSeconds(2f);
    //    SceneManager.LoadScene("LevelSelect");
    //}
}
