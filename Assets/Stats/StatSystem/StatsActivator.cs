using UnityEngine;

public class StatsActivator : MonoBehaviour, StatInteractable //Handles the call to the Stats Interaction
{
    [SerializeField] private StatsObject statsObject;

    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            player.Interactable = this;
        }
    }

    public void OnTriggerExit2D(Collider2D other)
    {
        if(other.CompareTag("Player") && other.TryGetComponent(out Player player))
        {
            if(player.Interactable is StatsActivator statsActivator && statsActivator == this)
            {
                player.Interactable = null;
            }
        }
    }

    public void Interact(Player player)
    {
        player.StatsUI.ShowStats(statsObject);
    }
}
