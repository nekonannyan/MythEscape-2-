using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Item item;

    [SerializeField]
    private GameObject slotGridPrefad;

    [SerializeField]
    private Image itemImage;
    [SerializeField]
    private Image bigItemImage = null;

    public Item Item { get => item; }
    private int index;



    public void Init(int index)
    {
        this.index = index;
    }
    public void OnItemBox()
    {    
        SlotGrid slotGrid = GameObject.Find("SlotGrid").GetComponent<SlotGrid>();

        if (slotGrid.allItems[index] != null)
        {
            bigItemImage.sprite = slotGrid.allItems[index].MyItemImage;
            itemImage.color = new Color(1, 1, 1, 1);
        }
        else
        {
            itemImage.color = new Color(0, 0, 0, 0);
        }

        Debug.Log("スロットの" + index);

        
    }
    public void SetItem(Item item)
    {
        this.item = item;//画像を表示

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
