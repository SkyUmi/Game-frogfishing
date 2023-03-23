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
        // Di chuy?n ??i t??ng l�n ho?c xu?ng d?a tr�n bi?n movingUp
        if (movingUp)
        {
            transform.Translate(Vector3.up * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.down * _speed * Time.deltaTime);
        }

        // N?u ??i t??ng ??t ??n v? tr� tr�n c�ng, ??i h??ng di chuy?n xu?ng
        if (transform.position.y > topPosition)
        {
            movingUp = false;
        }

        // N?u ??i t??ng ??t ??n v? tr� d??i c�ng, ??i h??ng di chuy?n l�n
        if (transform.position.y < bottomPosition)
        {
            movingUp = true;
        }
    }
}
