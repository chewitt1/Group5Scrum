using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public PlayerMovement player;
    public Dialogue dialogue;
    public Dialogue_Manager dMan;
    public bool triggered;
    public bool playerInRange;

    void Update()
    {
        // This handles the player starting a dialog box
        if (!triggered && ((Input.GetKeyUp(KeyCode.Space) || Input.GetButtonUp("Fire1")) && playerInRange))
        {
            TriggerDialogue();
            triggered = true;
            player.canMove = false;
        }
        // This handles the player continuing a dialog box
        else if(triggered && (Input.GetButtonUp("Fire1") || Input.GetKeyUp(KeyCode.Space)))
        // else if (triggered && Input.GetKeyUp(KeyCode.Space))
        {
            dMan.DisplayNextSentence();
            if(dMan.done)
            {
                triggered = false;
                player.canMove = true;
                playerInRange = false;
            }
        }
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        // This makes sure if the player in "front" of an interactable object
        if(other.CompareTag("Player"))
        {
            playerInRange = true;
            // Debug.Log("Player in range");
        }
    }

    public void TriggerDialogue()
    {
        // This connects Dialogue_Trigger to Dialogue_Manager
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }
}