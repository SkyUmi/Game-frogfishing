using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rod : MonoBehaviour
{
    [SerializeField]
    public string _tag; //type
    
    public float slowDown; //heavy maked the pod had slowdown
    
    public int score; //score of the frog

    void Awake()
    {
        this.tag = _tag;
    }
}
