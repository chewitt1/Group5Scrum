using System.Collections;
using UnityEngine;
using TMPro;

public class CloseStats : MonoBehaviour
{
    [SerializeField] private GameObject parent; //Will minimize the imports later, brute force for now


    public void CloseStatsButton()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {           
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
    }
}
