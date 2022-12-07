using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shortcuts : MonoBehaviour
{
    void Update()
    {
        // This simply quits the program
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }
}
