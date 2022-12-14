using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomTransition : MonoBehaviour
{
    public Vector2 cameraChange;
    public Vector3 playerChange;
    private CameraMovement cam;

    // Start is called before the first frame update
    void Start()
    {
        // The Camera is first collected to manipulate
        cam = Camera.main.GetComponent<CameraMovement>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // This alters not only the camera position, but also the player's position according to the room entrance they are in
        if(other.CompareTag("Player"))
        {
            cam.minPosition +=cameraChange;
            cam.maxPosition +=cameraChange;
            other.transform.position += playerChange;
        }
    }
}
