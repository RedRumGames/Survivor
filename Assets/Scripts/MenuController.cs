using UnityEngine;
using System.Collections;

public class MenuController : MonoBehaviour {

    public GameObject InventoryBG;
    public GameObject SlotBG;
    private bool active = false;
    
    public void OnBagClick()
    {
        if (InventoryBG.gameObject.activeInHierarchy == false)
        {
            InventoryBG.gameObject.SetActive(true);
        }
        else
        {
            InventoryBG.gameObject.SetActive(false);
        }
    }
}
