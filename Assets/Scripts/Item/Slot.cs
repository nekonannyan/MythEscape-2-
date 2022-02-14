using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField]
    private Image itemSlot;

    Item item;
    Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }

    //ƒAƒCƒeƒ€‚ª‚ ‚é‚©’²‚×‚é
    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    void UpdateImage(Item item)
    {
        itemSlot.color = Color.white;
        image.sprite = item.sprite;
    }
}
