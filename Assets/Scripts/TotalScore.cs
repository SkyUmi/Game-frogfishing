using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    [SerializeField] Text score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = "Total Score: " + ScoreHandleController.instance.score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
