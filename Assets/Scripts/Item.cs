using UnityEngine;
using System.Collections;

public enum ItemType { ArmyHelmet, Log, Medikit, Cannedfood};

public class Item : MonoBehaviour {
    public ItemType type;
    public Sprite spriteNormal;
    public Sprite spriteSelected;
    public int maxSize;

	public void Use()
    {
        switch (type)
        {
            case ItemType.ArmyHelmet:
                break;
            case ItemType.Log:
                break;
            case ItemType.Medikit:
                Debug.Log("Used MEDIKIT");
                break;
            case ItemType.Cannedfood:
                Debug.Log("Used Food");
                break;
        }
    }
}
