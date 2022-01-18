using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Item item;

    [SerializeField]
    private Image itemImage;

    public Item MyItem { get => item; }
    private int index;

    public void Init(int index)
    {
        this.index = index;
    }
    public void OnItemBox()
    {
        Debug.Log("ÉXÉçÉbÉgÇÃ" + index);
    }
    public void SetItem(Item item)
    {
        this.item = item;

        if (this.item != null)
        {
            itemImage.sprite = this.item.MyItemImage;
            itemImage.color = new Color(1, 1, 1, 1);

        }
        else
        {
            itemImage.color = new Color(0, 0, 0, 0);
        }
    }
}
