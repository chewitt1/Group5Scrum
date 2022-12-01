using System.Collections;
using UnityEngine;
using TMPro;

public class CloseStats : MonoBehaviour
{
    [SerializeField] private GameObject parent; //Will minimize the imports later, brute force for now
    [SerializeField] private GameObject statPhone;


    public void CloseStatsButton()
    {
        for (int i = 0; i < parent.transform.childCount; i++)
        {   
            Debug.Log("Num" + i);       
            var child = parent.transform.GetChild(i).gameObject;
            if (child != null)
                child.SetActive(false);
        }
        Destroy(statPhone);
    }
}
