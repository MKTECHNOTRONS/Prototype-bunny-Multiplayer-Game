using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
public class MainMenu : MonoBehaviour
{
     public void Awake()
    {
        EventSystem[] systems = FindObjectsOfType<EventSystem>();

        if (systems.Length > 1)
        {
            Debug.LogWarning("Multiple EventSystems found, destroying one.");
            Destroy(gameObject);
        }
    }

        public void PlayGame()
    {

        SceneManager.LoadSceneAsync("Game");
    }
    public void QuitGame()
    {
        Application.Quit();
   }
}
