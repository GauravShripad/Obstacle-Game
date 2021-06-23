using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float xRotate;
    [SerializeField] float yRotate;
    [SerializeField] float zRotate;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xRotate*Time.deltaTime,yRotate*Time.deltaTime,zRotate*Time.deltaTime);
    }
}
