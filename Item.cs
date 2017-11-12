using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class Item : ScriptableObject {

    new public string name = "New Item";
    public string description = "New Description";
    public Sprite icon = null;
    public int id = 0;
    public int capacity = 0;
    public int maxStackSize = 1;
    public int curStackSize = 0;

    public virtual void Use()
    {
        Debug.Log("Using: " + name);
        Debug.Log("2");
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.Remove(this);
        Debug.Log("4");
    }
}
