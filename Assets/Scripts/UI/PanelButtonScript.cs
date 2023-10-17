using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelButtonScript : MonoBehaviour
{
    public GameObject selectPanel, stopButton, levelSelectButton, mainMenuButton, replayButton;

    public void ReplayButton()
    {
        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        string sceneName = SceneManager.GetActiveScene().name;
        FadeInOut.instance.SceneFadeInOut(sceneName);
    }

    public void MainMenuButton()
    {
        //SceneManager.LoadScene("MainMenu");
        //Time.timeScale = 1.0f;
        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        FadeInOut.instance.SceneFadeInOut("MainMenu");
    }

    public void LevelSelectButton()
    {
        //SceneManager.LoadScene("LevelSelect");
        //Time.timeScale = 1.0f;
        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        FadeInOut.instance.SceneFadeInOut("LevelSelect");
    }

    public void NoButton()
    {
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, 1500f);

        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
    }

    public void YesButton() 
    {
        PlayerPrefs.DeleteAll();
        IsFirstTimePlayCheck checkScript = GameObject.Find("IsFirstTimePlayCheck").GetComponent<IsFirstTimePlayCheck>();
        checkScript.FirstTimePlayState();
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, 1500f);

        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
    }

    public void DataDeleteButton()
    {
        RectTransform DataDeleteImage = GameObject.Find("Canvas/SafeAreaPanel/DataDeleteImage").GetComponent<RectTransform>();
        DataDeleteImage.anchoredPosition = new Vector2(0f, -100f);

        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
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
        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        stopButton.SetActive(true);
    }

    public void SetStopButtonOff()
    {
        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        stopButton.SetActive(false);
    }

    public void MainMenuPlayButton()
    {
        GameObject mainMenuPlayer = GameObject.Find("MainMenuPlayer");
        Animator myAnim = mainMenuPlayer.GetComponent<Animator>();
        myAnim.SetBool("Run", true);

        GameObject playButton = GameObject.Find("Canvas/SafeAreaPanel/PlayButton");
        playButton.SetActive(false);

        BGMController myBGM = GameObject.Find("BGMController").GetComponent<BGMController>();
        myBGM.myAudioSource.PlayOneShot(myBGM.myButtonClip[0]);
        //StartCoroutine(LevelSelect());
        FadeInOut.instance.SceneFadeInOut("LevelSelect");
    }

    //private IEnumerator LevelSelect()
    //{
    //    yield return new WaitForSeconds(2f);
    //    SceneManager.LoadScene("LevelSelect");
    //}
}
