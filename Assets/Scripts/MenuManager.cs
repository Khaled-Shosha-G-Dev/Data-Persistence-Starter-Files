using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public static MenuManager instance;
    public string playerName;
    public int highScore ;
    [System.Serializable]
    class SaveData
    {
        public string name;
        public int highScore;
    }

    public void LoadPlayerData()
    {
        string path = Application.persistentDataPath+"/SaverData.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);
            playerName = data.name;
            highScore = data.highScore;
        }
    }
    public void SavePlayerData()
    {
        SaveData data = new SaveData();
        data.name = playerName;
        data.highScore = highScore;
        string json= JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/SaverData.json", json);
    }

    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }

   
}
