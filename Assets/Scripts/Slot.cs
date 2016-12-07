using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class Slot : MonoBehaviour {
    private Stack<Item> items;
    public Text stackText;
    public Sprite slotEmpty;

    public bool IsEmpty
    {
        get { return items.Count == 0; }
    }

	// Use this for initialization
	void Start ()
    {
        items = new Stack<Item>();
        RectTransform slotRect = GetComponent<RectTransform>();
        RectTransform textRect = GetComponent<RectTransform>();

        int textScaleFactor = (int)(slotRect.sizeDelta.x * 0.60);
        stackText.resizeTextMaxSize = textScaleFactor;
        stackText.resizeTextMinSize = textScaleFactor;

        textRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotRect.sizeDelta.y);
        textRect.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, slotRect.sizeDelta.x);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void AddItem(Item item)
    {
        items.Push(item);

        if (items.Count > 1)
        {
            stackText.text = items.Count.ToString();
        }
        ChangeSprite(item.spriteNormal, item.spriteSelected);
    }

    private void ChangeSprite(Sprite normal, Sprite selected)
    {
        GetComponent<Image>().sprite = normal;

        SpriteState st = new SpriteState();
        st.highlightedSprite = selected;
        st.pressedSprite = normal;

        GetComponent<Button>().spriteState = st;
    }
}
