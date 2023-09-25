using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinTrigger : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.name == "Player")
        {
            string levelName = SceneManager.GetActiveScene().name;
            string temp = levelName.Substring(5);
            int levelNumber = int.Parse(temp);

            PlayerPrefs.SetInt("clearedLevel", levelNumber);
            SceneManager.LoadScene("LevelSelect");
        }
    }
}
