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
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {
        Debug.Log("Starting Converstation with " + dialogue.name);

        // nameText.text = dialogue.name;

        dialogBox.SetActive(true);
        done = false;

        sentences.Clear();

        foreach (string s in dialogue.sentences)
        {
            // Debug.Log(s);
            sentences.Enqueue(s);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {
        if(sentences.Count == 0) 
        {
            EndDialogue();
            dialogBox.SetActive(false);

            return;
        }

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