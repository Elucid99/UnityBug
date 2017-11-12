using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour {

    public Image icon;          // Reference to the Icon image
    public Button removeButton; // Reference to the remove button
    public Text itemName;
    public Text itemDesc;
    public Text stackSize;
    public Text capacity;

    GameObject slotBox;

    Item item;  // Current item in the slot

    private void Start()
    {
        slotBox = transform.gameObject;
    }

    // Add item to the slot
    public void AddItem(Item newItem)
    {
        if(newItem != null)
        {
            item = newItem;

            if(item == null)
            {
                AddItem(newItem);
                return;
            }
            icon.sprite = item.icon;
            removeButton.interactable = true;
            itemName.text = item.name;
            itemDesc.text = item.description;
        }
    }

    // Clear the slot
    public void ClearSlot()
    {
        item = null;
        Destroy(slotBox);
        //icon.sprite = null;
        //icon.enabled = false;
        //removeButton.interactable = false;
        //this.enabled = false;
    }

    // Called when the remove button is pressed
    public void OnRemoveButton()
    {
        Inventory.instance.Remove(item);

    }

    // Called when the item is pressed
    public void UseItem()
    {
        if (item != null)
        {
            item.Use();
        }
    }

    void Update()
    {
        if(item == null)
        {
            //Destroy(slotBox);
        }
    }
}
