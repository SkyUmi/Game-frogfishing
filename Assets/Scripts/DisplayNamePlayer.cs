using System.Collections;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class DisplayNamePlayer : MonoBehaviour
{
    public Text nameplayer;
    public InputField display;
    public static DisplayNamePlayer displayName;
    protected List<InfoPlayer> ScoreSave = new List<InfoPlayer>();
    // Start is called before the first frame update
    void Start()
    {
        nameplayer.text = PlayerPrefs.GetString("Player");
    }
    public void Create()
    {
        display.gameObject.SetActive(false);
        nameplayer.text = "Player: " + display.text;
        PlayerPrefs.SetString("Player", nameplayer.text);
        PlayerPrefs.Save();

        if (File.Exists(Application.dataPath + "/scores.json"))
        {
            var value = File.ReadAllText(Application.dataPath + "/scores.json");

            List<InfoPlayer> score_save = JsonConvert.DeserializeObject<List<InfoPlayer>>(value);
            if (score_save != null)
            {
                ScoreSave = score_save;
            }
        }

        InfoPlayer new_info = new InfoPlayer();

        new_info.name_player = display.text;
        new_info.score_player = ScoreHandleController.instance.score;
        if (ScoreSave == null)
        {
            ScoreSave = new List<InfoPlayer>();
        }    
        ScoreSave.Add(new_info);


        string save_value = JsonConvert.SerializeObject(ScoreSave);
       // string _save_value = JsonUtility.ToJson(ScoreSave.infoes);
        File.WriteAllText(Application.dataPath + "/scores.json", save_value);

    }

 
}

public class ScoreSaved
{
    public List<InfoPlayer> infoes;

}
public class InfoPlayer
{
    public string name_player;
    public int score_player;
}