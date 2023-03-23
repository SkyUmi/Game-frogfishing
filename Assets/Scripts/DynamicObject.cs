using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicObject : Rod
{
    Vector3 start;
    Vector3 end;
    [SerializeField]
    private int _speed;



    

    void Start()
    {
        // start is object go to left 2dv
        // end is object go to right 2dv
        // total 4dv
        start = transform.position;
        start += Vector3.left * 8;
        end = transform.position;
        end += Vector3.right * 8;   
    }


    void Update()
    {
        if (check(start) || check(end))
        {
            _speed *= -1;
            //transform.Rotate(new Vector3(0, 180, 0));
            //transform.Translate(Vector3.left * _speed * Time.deltaTime);

        }
        //transform.Translate(Vector3.right * _speed*Time.deltaTime);
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }

    private bool check (Vector3 point)
    {
        return Mathf.Floor(point.x) == Mathf.Floor(transform.position.x);
    }
}
