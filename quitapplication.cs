using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitapplication : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("We pushed escape");
            Application.Quit();
        }
    }
}
