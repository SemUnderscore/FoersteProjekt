using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{ public float MovementSpeed = 3;
    private void Start()
    {

    }

    private void Update()
    {
        var HorizontalMovement = Input.GetAxis("Horizontal");
            transform.position += new Vector3(HorizontalMovement, 0, 0) * Time.deltaTime * MovementSpeed;
        var VerticalMovement = Input.GetAxis("Vertical");
        transform.position += new Vector3(0,VerticalMovement, 0) * Time.deltaTime * MovementSpeed;



    }



}