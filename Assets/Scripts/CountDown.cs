using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    private float totalTime = 25f;
    private float timeLeft;
    [SerializeField] Text timeText;
    // Start is called before the first frame update
    void Start()
    {
        timeLeft = totalTime;
    }

    // Update is called once per frame
    void Update()
    {
        timeLeft -= 1 * Time.deltaTime;
        timeText.text = "Time: " + timeLeft.ToString("0") + "/25";
        if (timeLeft <= 0)
        {
            timeLeft = 0;
        }

    }
}
