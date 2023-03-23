using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFish : Rod
{
    Vector3 start;
    //Vector3 end;
    private float leftScreenEdge;
    private float rightScreenEdge;
    [SerializeField]
    private int _speed;
    void Start()
    {
        // start is object go to left 2dv
        // end is object go to right 2dv
        // total 4dv
        start = transform.position;

        // Tính toán gi?i h?n c?a màn hình
        Camera mainCamera = Camera.main;
        float cameraHeight = 2.0f * mainCamera.orthographicSize;
        float cameraWidth = cameraHeight * mainCamera.aspect;
        leftScreenEdge = -cameraWidth / 2.0f;
        rightScreenEdge = cameraWidth / 2.0f;
    }

    void Update()
    {

        transform.Translate(Vector3.left * _speed * Time.deltaTime);

        // N?u nhân v?t ?i ra kh?i màn hình bên trái, ??t l?i v? trí c?a nó ? bên ph?i
        if (transform.position.x < leftScreenEdge)
        {
            transform.position = new Vector3(rightScreenEdge, start.y);
        }
    }


}
