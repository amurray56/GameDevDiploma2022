using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    
    public void PlayButton(string levelToLoad)
    {
        SceneManager.LoadScene(levelToLoad);
        Debug.Log("We are now playing the Game!");
    }
}
