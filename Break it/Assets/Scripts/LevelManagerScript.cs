using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManagerScript : MonoBehaviour
{
    public Button[] levels;

    private void Start()
    {
        int levelReached = PlayerPrefs.GetInt("levelReached", 0);
        for (int i = 0; i < levels.Length; i++)
        {
            if(i > levelReached)
            {
                levels[i].interactable = false;
            }
        }
    }
    public void Select(int levelName)
    {
        const int numberOfPreScene = 2;
        SceneManager.LoadScene(levelName + numberOfPreScene);
    }

}