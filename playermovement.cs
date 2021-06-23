using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
       MovePlayer();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome To the Game");
        Debug.Log("Move with your player with WASD keys");
        Debug.Log("Dont hit the walls");
    }

    void MovePlayer()
    {
        float xValue = Input.GetAxis("Horizontal")* Time.deltaTime * moveSpeed;
        float zValue = Input.GetAxis("Vertical")* Time.deltaTime * moveSpeed;
        transform.Translate(xValue,0,zValue);
    }
}
