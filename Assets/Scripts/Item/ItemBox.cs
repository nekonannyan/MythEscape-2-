using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots ;
    [SerializeField] Slot selectedSlot = null;

    //どこでも実行出来るようにする
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //スロットにアイテムを入れる
    public void SetItem(Item item)
    {
        //アイテムを左寄せで入れる
        foreach (Slot slot in slots)
        {
            if (slot.IsEmpty())
            {
                slot.SetItem(item);
                break;
            }
        }
    }

    public void OnSelectSlot(int position)
    {
        foreach(Slot slot in slots)
        {
            slot.HideBgPanel();
        }
        if(slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
    }
}