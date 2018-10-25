using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Navigation : MonoBehaviour {

  public static bool fromMenu;

  public void MenuToPlay()
  {

    SceneManager.LoadScene("GameScene",LoadSceneMode.Single);
  }
  public void PlayToMenu()
  {

    SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
  }
  public void MenuToOptions()
  {
    fromMenu = true;
    SceneManager.LoadScene("OptionMenu",LoadSceneMode.Single);
  }
  public void PlayToOptions()
  {
    fromMenu = false;
    SceneManager.LoadScene("OptionMenu",LoadSceneMode.Single);
  }               
  public void OptionsBack()
  {  
    if (fromMenu)
      {
        OptionsToMenu();
      }
    else
      {
        OptionsToPlay();
      }
  }
  public void OptionsToMenu()
  {

    SceneManager.LoadScene("MainMenu",LoadSceneMode.Single);
  }
  public void OptionsToPlay()
  {

    SceneManager.LoadScene("GameScene",LoadSceneMode.Single);
  }
	public void QuitGame()
  {
    #if UNITY_EDITOR
      UnityEditor.EditorApplication.isPlaying = false;
    #else
      Application.Quit();
    #endif
  }
}
