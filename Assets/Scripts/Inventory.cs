using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour {
    private RectTransform inventoryRect;
    private float inventoryWidth, inventoryHeight;
    public int Slots;
    public int Rows;
    public float slotPaddingLeft, slotPaddingTop;
    public float slotSize;
    public float additive;
    public float spacing;
    public float leftTopPadding;
    public GameObject slotPrefab;
    public GameObject inventoryParent;
    private int emptySlots;

    public GameObject InventoryBG;

    private List<GameObject> allSlots;

    public int AmtOfLogs;

	// Use this for initialization
	void Start ()
    {
        CreateLayout();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OnBagClick()
    {
        if (InventoryBG.gameObject.activeInHierarchy == false)
        {
            InventoryBG.gameObject.SetActive(true);
            foreach (GameObject newSlot in allSlots)
            {
                newSlot.SetActive(true);
            }
            
        }
        else
        {
            InventoryBG.gameObject.SetActive(false);
            foreach (GameObject newSlot in allSlots)
            {
                newSlot.SetActive(false);
            }
        }
    }

    private void CreateLayout()
    {
        allSlots = new List<GameObject>();

        emptySlots = Slots;

        inventoryWidth = ((Slots / Rows) * (slotSize + slotPaddingLeft) + slotPaddingLeft) - additive;//6 x 32 + 2
        inventoryHeight = (Rows * (slotSize + slotPaddingTop) + slotPaddingTop) - additive;

        inventoryRect = GetComponent<RectTransform>();

        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, inventoryWidth);
        inventoryRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, inventoryHeight);

        int Columns = Slots / Rows;

        for(int y = 0; y < Rows; y++)
        {
            for(int x = 0; x < Columns; x++)  
            {
                GameObject newSlot = (GameObject)Instantiate(slotPrefab);

                RectTransform slotRect = newSlot.GetComponent<RectTransform>();

                newSlot.name = "Slot";

                //newSlot.transform.SetParent(inventoryParent.transform);
                newSlot.transform.SetParent(this.transform.parent);

                //slotRect.localPosition = inventoryRect.localPosition + new Vector3(slotPaddingLeft * (x + 1) + (slotSize * x), -slotPaddingTop * (y + 1) - (slotSize * y));
                slotRect.localPosition = inventoryRect.localPosition + new Vector3(slotPaddingLeft - spacing * (x + 1) + (slotSize * x) + leftTopPadding, -slotPaddingTop + spacing * (y + 1) - (slotSize * y) - leftTopPadding);

                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, slotSize);
                slotRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotSize);

                allSlots.Add(newSlot);
            }
        }
    }

    private bool AddItem(Item item)
    {
        if (item.maxSize == 1)
        {
            PlaceEmpty(item);
            return true;
        }
        return false;
    }

    private bool PlaceEmpty(Item item)
    {
        if (emptySlots > 0)
        {
            foreach (GameObject slot in allSlots)
            {
                Slot tmp = slot.GetComponent<Slot>();

                if (tmp.IsEmpty)
                {
                    tmp.AddItem(item);
                    emptySlots--;
                    return true;
                }
            }
        }
        return false;
    }
}
