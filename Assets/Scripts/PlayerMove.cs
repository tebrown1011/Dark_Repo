using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float playerSpeed;
   
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float moveY = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        transform.position += new Vector3(moveX, moveY);
    }
}
