using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue_Manager : MonoBehaviour
{
    // public Text nameText;
    public GameObject dialogBox;
    public Text dialogText;

    private Queue<string> sentences;
    public bool done;
    
    // Start is called before the first frame update
    void Start()
    {
        // This will hold the sentences that will be apart of the Dialogue Text
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        // Debug.Log("Starting Converstation with " + dialogue.name);


        // This displays the dialogue box
        dialogBox.SetActive(true);
        done = false;

        // First we must clear the previous sentence from the Dialogue Box
        sentences.Clear();

        // The sentences will be queued up for toggling
        foreach (string s in dialogue.sentences)
        {
            // Debug.Log(s);
            sentences.Enqueue(s);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        // Debug.Log("sentence count: " + sentences.Count);

        // Once there are no more sentences queued up, we will end the Dialogue Routine
        if(sentences.Count == 0) 
        {
            EndDialogue();
            dialogBox.SetActive(false);

            return;
        }

        // After the sentence is displayed to the dialogue box, it is removed from the equeue of sentences
        string sentence = sentences.Dequeue();
        dialogText.text = sentence;
        Debug.Log(sentence);
    }

    void EndDialogue()
    {
        Debug.Log(("End of conversation."));
        done = true;
    }
}