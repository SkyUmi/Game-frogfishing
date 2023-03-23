using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicFrog : Rod
{

    [SerializeField]
    private float _speed;
    public float topPosition ;
    public float bottomPosition ;

    private bool movingUp = true;

    private void Update()
    {
        // Di chuy?n ??i t??ng lên ho?c xu?ng d?a trên bi?n movingUp
        if (movingUp)
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        // N?u ??i t??ng ??t ??n v? trí trên cùng, ??i h??ng di chuy?n xu?ng
        if (transform.position.y > topPosition)
        {
            movingUp = false;
        }

        // N?u ??i t??ng ??t ??n v? trí d??i cùng, ??i h??ng di chuy?n lên
        if (transform.position.y < bottomPosition)
        {
            movingUp = true;
        }
    }
}
