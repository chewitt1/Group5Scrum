using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private StatsUI statsUI;

    public StatsUI StatsUI => statsUI;

    public StatInteractable Interactable{ get; set; }

    private bool done = false;

    private void Update()
    {
        if(statsUI.isOpen){ 
            done = true;
            return;
        }

        if(!done){
            if(Interactable != null)
            {
                Interactable.Interact(this);
            }
        }
    }
}
