using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class HighScoreUI: MonoBehaviour
{
    [SerializeField] GameObject panel;
    [SerializeField] GameObject container;
    [SerializeField] GameObject highscoreUIElementPrefab;
    [SerializeField] GameObject Element;
    [SerializeField] Transform elementWrapper;
    List<DisplayNamePlayer> playerList = new List<DisplayNamePlayer>();



    List<GameObject> uiElements = new List<GameObject>();

    private void OnEnable()
    {
        HighScoreHandle.onHighscoreListChanged += UpdateUI;
    }

    private void OnDisable()
    {
        HighScoreHandle.onHighscoreListChanged -= UpdateUI;
    }
    public void ShowPanel()
    {
        if (File.Exists(Application.dataPath + "/scores.json"))
        {
            var value = File.ReadAllText(Application.dataPath + "/scores.json");

            List<InfoPlayer> score_save = JsonConvert.DeserializeObject<List<InfoPlayer>>(value);
            if (score_save != null)
            {
               
                    for (int num_player = 0; num_player < score_save.Count; num_player++)
                    {
                        GameObject OneInfoLine = Instantiate(highscoreUIElementPrefab, Element.transform);
                        var texts = OneInfoLine.GetComponentsInChildren<Text>();
                        texts[0].text = score_save[num_player].name_player;
                        texts[1].text = score_save[num_player].score_player.ToString();
                    }
                  
            }    
        
        }
        container.SetActive(false);
        panel.SetActive(true);
    }
    public void ClosePanel()
    {
        panel.SetActive(false);
        container.SetActive(true);
    }

    private void UpdateUI(List<HighScoreElement> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            HighScoreElement el = list[i];

            if (el != null && el.score > 0)
            {
                if (i >= uiElements.Count)
                {
                    // instantiate new entry
                    var inst = Instantiate(highscoreUIElementPrefab, Vector3.zero, Quaternion.identity);
                    inst.transform.SetParent(elementWrapper, false);

                    uiElements.Add(inst);
                }

                // write or overwrite name & points
                var texts = uiElements[i].GetComponentsInChildren<Text>();
                texts[0].text = el.playerName;
                texts[1].text = el.score.ToString();
            }
        }

        //if (File.Exists(Application.dataPath + "/scores.json"))
        //{
        //    string value = File.ReadAllText(Application.dataPath + "/scores.json");

        //    ScoreSaved score_save = JsonUtility.FromJson<ScoreSaved>(value);

        //    var texts = highscoreUIElementPrefab.GetComponentsInChildren<Text>();
        //    texts[0].text =score_save.name_player;
        //    texts[1].text = score_save.score_player.ToString();
        //}
    }

}
