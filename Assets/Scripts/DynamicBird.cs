using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicBird : Rod
{

    [SerializeField]
    private int _speed;

    private bool isMovingRight = true; // variable to determine the direction of movement of the animal

    // Update is called once per frame
    void Update()
    {
        // movement object to right
        if (isMovingRight)
        {
            transform.position += new Vector3(_speed * Time.deltaTime, 0, 0); // di chuy?n con v?t sang ph?i
            transform.localScale = new Vector3(3, 3, 3); // keep the same direction of the animal
        }
        // movement object to left
        else
        {
            transform.position -= new Vector3(_speed * Time.deltaTime, 0, 0); // movement object to left
            transform.localScale = new Vector3(-3, 3, 3); // reversing the direction of the animal
        }

        // if the animal goes to the right point then change direction
        if (transform.position.x >= 15f)
        {
            isMovingRight = false;
        }
        // if the animal goes to the left point then change direction
        else if (transform.position.x <= 0f)
        {
            isMovingRight = true;
        }
    }
}

    
