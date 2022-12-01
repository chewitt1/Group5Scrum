using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource FootstepSound;

    void Upddate()
    {
        if((Input.GetKey(KeyCode.W)) || (Input.GetKey(KeyCode.A)) || (Input.GetKey(KeyCode.S))  || (Input.GetKey(KeyCode.D)))
        {
            FootstepSound.enabled = true;
        }
            
        else
        {
            FootstepSound.enabled = false;
        }
    }
}
