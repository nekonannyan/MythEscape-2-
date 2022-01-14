using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefad;
    [SerializeField]
    private Item[] allTtems;

    private int slotNumber = 5;


    void Start()
    {
        for (int i = 0; i < slotNumber; i++)
        {
            GameObject slotObj = Instantiate(slotPrefad, this.transform);
            Slot slot = slotObj.GetComponent<Slot>();

            if (i < allTtems.Length)
            {
                slot.SetItem(allTtems[i]);
            }
            else
            {
                slot.SetItem(null);
            }
        }

    }
}
