using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefad;
    [SerializeField]
    public Item[] allItems;

    private int slotNumber = 5;//スロットの数


    void Start()
    {
        //スロットを作る
        for (int i = 0; i < slotNumber; i++)
        {
            GameObject slotObj = Instantiate(slotPrefad, this.transform);
            Slot slot = slotObj.GetComponent<Slot>();
            slot.Init(i + 1);
            
            //スロットにアイテムをセット
            if (i < allItems.Length)
            {
                slot.SetItem(allItems[i]);
            }
            else
            {
                slot.SetItem(null);
            }
        }
    }
}
