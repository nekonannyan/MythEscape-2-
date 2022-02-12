using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    //どこでも実行出来るようにする
    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    //スロットにアイテムを入れる
    public void SetItem(ItemType item)
    {
        slots[0].SetItem(item);
       // Debug.Log("Set");
    }
}
