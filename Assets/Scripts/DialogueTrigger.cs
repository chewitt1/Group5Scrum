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
        if(!triggered && (Input.GetButtonUp("Fire1") && playerInRange))
        {
            TriggerDialogue();
            triggered = true;
            player.canMove = false;
        }
        else if(triggered && Input.GetButtonUp("Fire1"))
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
        if(other.CompareTag("Player"))
        {
            playerInRange = true;
            // Debug.Log("Player in range");
        }
    }

    public void TriggerDialogue()
    {
        FindObjectOfType<Dialogue_Manager>().StartDialogue(dialogue);
    }
}