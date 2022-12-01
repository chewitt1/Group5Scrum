using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TypewriterEffect : MonoBehaviour
{
    [SerializeField] private float tyepwriterSpeed = 50f; //Serialized so that I can edit it inside of Unity

    public Coroutine Run(string textToType, TMP_Text textLabel) // Driver Method
    {
        return StartCoroutine(TypeText(textToType, textLabel));
    }

    private IEnumerator TypeText(string textToType, TMP_Text textLabel) //Core Functionality Method (Coroutine)
    {
        textLabel.text = string.Empty; //Make sure box is empty (no placeholder text)
        
        //yield return new WaitForSeconds(1);

        float t = 0; //Elasped time since we started writing
        int charIndex = 0; //A floored value of 't' to manage # of chars being typed at a time/frame

        while (charIndex < textToType.Length) //Type one char at a time
        {
            t += Time.deltaTime * tyepwriterSpeed;
            charIndex = Mathf.FloorToInt(t);
            charIndex = Mathf.Clamp(charIndex, 0, textToType.Length); //Ensure that charIndex is never greater than text length

            textLabel.text = textToType.Substring(0, charIndex); //Append the chars one by one

            yield return null;
        }

        textLabel.text = textToType; //Ensure that the text label text is equal to what I actually want to type
    }
}
