using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainUI : MonoBehaviour
{
    public Text name;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        name.text = "Name : "+MenuManager.instance.playerName + "\nBest Score : "+ MenuManager.instance.highScore;
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
