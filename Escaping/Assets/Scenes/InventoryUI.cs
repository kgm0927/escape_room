using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class InventoryUI : MonoBehaviour
{




    public CanvasGroup inventoryPanel;
    bool activeInventory = true;
    private Slot[] slots; 



    private void Start() {
        inventoryPanel =GetComponent<CanvasGroup>();
    
       slots=GameObject.FindObjectsOfType<Slot>();

    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.I))
        {
            activeInventory = !activeInventory;
            inventoryPanel.interactable = !inventoryPanel.interactable;
            inventoryPanel.blocksRaycasts = !inventoryPanel.blocksRaycasts;
            inventoryPanel.alpha = (inventoryPanel.alpha == 1) ? 0 : 1;
        }
    }

    

}
