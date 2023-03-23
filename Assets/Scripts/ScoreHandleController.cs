using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandleController : MonoBehaviour
{
    [SerializeField] public int score;
    public static ScoreHandleController instance;
    Pod Pod;
    // Start is called before the first frame update
    void Awake()
    {
        if (instance == null)
            instance = this;
        DontDestroyOnLoad(gameObject);
        try
        {
            Pod = GameObject.FindGameObjectWithTag("Pod").GetComponent<Pod>();
        }
        catch { }
        

    }
    private void OnLevelWasLoaded(int level)
    {
        GameObject[] ScoreHandles = GameObject.FindGameObjectsWithTag("Score");
        if (ScoreHandles.Length > 10)
            {
            Destroy(ScoreHandles[1]);
        }
    }

    // Update is called once per frame
    
}
