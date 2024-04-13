using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryUI : MonoBehaviour
{




    public GameObject inventoryPanel;
    bool activeInventory = true;
    private Slot[] slots; 



    private void Start() {
        inventoryPanel.SetActive(activeInventory);
       slots=GameObject.FindObjectsOfType<Slot>();

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.SetActive(activeInventory);
        }
    }

    

}
