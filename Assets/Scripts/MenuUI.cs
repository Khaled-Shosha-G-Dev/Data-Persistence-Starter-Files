using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUI : MonoBehaviour
{

    public TMP_InputField name;
    public TextMeshProUGUI score;
    private void Start()
    {
        MenuManager.instance.LoadPlayerData();
        score.text = "Best Score : "+MenuManager.instance.highScore;
        name.text = MenuManager.instance.playerName;
    }
    //Start button
    public void StartGame()
    {
        SceneManager.LoadScene("main");
    }
    //Quit Button
    public void QuitApplication()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }

    //Save Data auto when player click start 
    public void SaveName()
    {
        MenuManager.instance.playerName = name.text;
        MenuManager.instance.highScore = 0;
        MenuManager.instance.SavePlayerData();
    }


}
