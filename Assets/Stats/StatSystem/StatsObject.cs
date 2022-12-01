using UnityEngine;

[CreateAssetMenu(menuName = "Stats/StatsObject")] //menuName points of object path (creates a new Unity Entity type)

public class StatsObject : ScriptableObject
{
    [SerializeField] [TextArea] private string[] stat;

    public string[] Stats => stat; //Getter (outside code can only read, !write)
}
