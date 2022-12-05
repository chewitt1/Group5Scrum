using System.Collections;
using UnityEngine;
using TMPro;//Text Mesh Pro for, well, the text.

public class StatsUI : MonoBehaviour
{
    [SerializeField] private GameObject statsBox;
    [SerializeField] private GameObject statsClose;
    [SerializeField] private TMP_Text textLabel;//A refernce to the text label
    //[SerializeField] private StatsObject testStats;

    public bool isOpen { get; private set; }

    private TypewriterEffect typewriterEffect;

    //Method for getting/generating text (Use later for choosing correct statistic)
    private void Start()
    {
        typewriterEffect = GetComponent<TypewriterEffect>();

        statsBox.SetActive(false);
        textLabel.text = string.Empty;

        statsClose.SetActive(false);
        //ShowStats(testStats);
    }

    public void ShowStats (StatsObject statObject)//Driver for showing stats
    {
        isOpen = true;
        statsBox.SetActive(true);
        StartCoroutine(StepThroughStats(statObject));
    }

    private IEnumerator StepThroughStats (StatsObject statObject)//Get each stat
    {
        textLabel.text = statObject.Stats[0];
        //yield return typewriterEffect.Run(statObject.Stats[0], textLabel); //Just print one stat for now
        yield return new WaitForSeconds(3); //Stay long enough to read

        /*foreach (string stat in statObject.Stats) //change this to print only a specific stat
        {
            yield return typewriterEffect.Run(stat, textLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Tab)); //Add a extra 10 seconds wait so they actually read the thing
        }*/

        /*for(int i = 0; i < statsObject.Stats.Length; i++)
        {
            string stats = statsObject.Stats[i];
            yield return typewriterEffect.Run(stat, textLabel);
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.Space)); //Add a extra 10 seconds wait so they actually read the thing
        }*/
        //yield return null;
        CloseStatsBox();
    }

    private void CloseStatsBox() {
        isOpen = false;
        //statsBox.SetActive(false);
        statsClose.SetActive(true);
    }
}
