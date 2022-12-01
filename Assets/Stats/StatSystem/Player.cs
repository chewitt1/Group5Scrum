using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private StatsUI statsUI;

    public StatsUI StatsUI => statsUI;

    public StatInteractable Interactable{ get; set; }

    private void Update()
    {
        if(Interactable != null)
        {
            Interactable.Interact(this);
        }
    }
}
