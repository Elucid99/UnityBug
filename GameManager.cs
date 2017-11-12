using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public Item itemToAdd;
    public Item itemToAdd2;
    public Item itemToAdd3;
    public Item itemToAdd4;

    // Use this for initialization
    void Start () {
        Inventory.instance.Add(itemToAdd2);
        Inventory.instance.Add(itemToAdd3);
        Inventory.instance.Add(itemToAdd4);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
