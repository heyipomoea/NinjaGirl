﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SelectSceneButtonScript : MonoBehaviour
{
    public Sprite buttonSprite;

    Image imageBtn1, imageBtn2, imageBtn3;

    int clearedLevel;

    private void Awake()
    {
        imageBtn1 = GameObject.Find("Canvas/SafeAreaPanel/SelectPanelBGImage/Level1Button").GetComponent<Image>();
        imageBtn2 = GameObject.Find("Canvas/SafeAreaPanel/SelectPanelBGImage/Level2Button").GetComponent<Image>();
        imageBtn3 = GameObject.Find("Canvas/SafeAreaPanel/SelectPanelBGImage/Level3Button").GetComponent<Image>();

        clearedLevel = PlayerPrefs.GetInt("clearedLevel");

        if(clearedLevel == 0)
        {
            imageBtn1.sprite = buttonSprite;
        }
        else if(clearedLevel <= 1)
        {
            imageBtn1.sprite = buttonSprite;
            imageBtn2.sprite = buttonSprite;
        }
        else if(clearedLevel >= 2)
        {
            imageBtn1.sprite = buttonSprite;
            imageBtn2.sprite = buttonSprite;
            imageBtn3.sprite = buttonSprite;
        }
    }

    public void GoToLevel1()
    {
        //SceneManager.LoadScene("Level1");
        FadeInOut.instance.SceneFadeInOut("Level1");
    }

    public void GoToLevel2()
    {
        if(clearedLevel >= 1)
        {
            //SceneManager.LoadScene("Level2");
            FadeInOut.instance.SceneFadeInOut("Level2");
        }
    }

    public void GoToLevel3()
    {
        if(clearedLevel >= 2)
        {
            //SceneManager.LoadScene("Level3");
            FadeInOut.instance.SceneFadeInOut("Level3");
        }
    }

    public void GoToMainMenu()
    {
        //SceneManager.LoadScene("MainMenu");
        FadeInOut.instance.SceneFadeInOut("MainMenu");
    }
}
