using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class HighScoreHandle : MonoBehaviour
{
    List<HighScoreElement> highscoreList = new List<HighScoreElement>();
    [SerializeField] int maxCount = 7;
    [SerializeField] string fileName;

    private void Start()
    {
        LoadHighScore();
    }
    public delegate void OnHighscoreListChanged(List<HighScoreElement> list);
    public static event OnHighscoreListChanged onHighscoreListChanged;
    private void LoadHighScore()
    {
        highscoreList = FileHandler.ReadListFromJSON<HighScoreElement> (fileName);

        while(highscoreList.Count > maxCount)
        {
            highscoreList.RemoveAt (maxCount);
        }
        if (onHighscoreListChanged != null)
        {
            onHighscoreListChanged.Invoke(highscoreList);
        }
    }
    private void SaveHighScore()
    {
        FileHandler.SaveToJSON<HighScoreElement>(highscoreList, fileName);
    }

    public void AddHighScoreIfPossible (HighScoreElement element)
    {
        for (int i = 0; i < maxCount; i++)
        {
            if (i >= highscoreList.Count || element.score > highscoreList[i].score)
            {
                highscoreList.Insert(i, element);

                while (highscoreList.Count > maxCount)
                {
                    highscoreList.RemoveAt(maxCount);
                }

                SaveHighScore();
                if (onHighscoreListChanged != null)
                {
                    onHighscoreListChanged.Invoke(highscoreList);
                }
                break;
            }

        }

        
    }
}
