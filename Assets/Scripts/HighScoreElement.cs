using System;
[Serializable]
public class HighScoreElement 
{
    public string playerName;
    public int score;

    public HighScoreElement (string name, int score)
    {
        //playerName = DisplayNamePlayer.displayName.nameplayer.text;
        //this.score = ScoreHandleController.instance.score;

        playerName = name;
        this.score = score;

    }
}
