using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class savejson : MonoBehaviour
{
    private string filePath;
    private Dictionary<string, int> scores = new Dictionary<string, int>();
    private Dictionary<string, string> name = new Dictionary<string, string>();

    private void Awake()
    {
        filePath = Application.dataPath + "/scores.json";

        if (File.Exists(filePath))
        {
            string json = File.ReadAllText(filePath);
            scores = JsonUtility.FromJson<Dictionary<string, int>>(json);
            //name = JsonUtility.ToJson(DisplayNamePlayer.displayName.nameplayer.text);
        }
        else
        {
            scores = new Dictionary<string, int>();
        }
    }

    public void AddScore(string name, int score)
    {
        if (scores.ContainsKey(name))
        {
            scores[name] += score;
        }
        else
        {
            scores.Add(name, score);
        }

        SaveScores();
    }

    public void SaveScores()
    {
        string json = JsonUtility.ToJson(scores, true);
        File.WriteAllText(filePath, json);
    }
}
