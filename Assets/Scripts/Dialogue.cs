using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This is simply used to make the Inspector more simple to insert sentences for dialogue
[System.Serializable]
public class Dialogue
{
    public string name;
    public string[] sentences;

    private Dialogue_Manager dMan;

}