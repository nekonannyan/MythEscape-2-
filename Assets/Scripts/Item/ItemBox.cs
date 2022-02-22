using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;

    public GameObject zoomObj;

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
    //スロット選択時に実行する
    public void OnSelectSlot(int position)
    {
        foreach (Slot slot in slots)
        {
            slot.ColorRestore();
        }
        if (selectedSlot == slots[position])
        {
            Debug.Log("2kai");
            zoomObj.GetComponent<ZoomItem>().ShowPanel();
        }
        //選択されているアイテムをグレーにする
        if (slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }
    }


    //アイテムの使用を試みる
    public bool TryUseItem(Item.Type type)
    {
        if (selectedSlot == null)
        {
            return false;
        }

        if (selectedSlot.GetItem().type == type)
        {
            //selectedSlot.SetItem(null);
            selectedSlot.ColorRestore();
            selectedSlot = null;
            return true;
        }

        return false;
    }

    public Item GetSelectedItem()
    {
        if (selectedSlot == null)
        {
            return null;
        }
        return selectedSlot.GetItem();
    }
}