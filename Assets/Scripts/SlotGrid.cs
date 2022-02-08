using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlotGrid : MonoBehaviour
{
    [SerializeField]
    private GameObject slotPrefad;
    [SerializeField]
    private Item[] allItems;


    private ItemData itemData;

    private int slotNumber = 5;//�X���b�g�̐�
    private List<Slot> slotList = new List<Slot>();


    void Start()
    {

        //�X���b�g�����
        for (int i = 0; i < slotNumber; i++)
        {
            var slotObj = Instantiate(slotPrefad, this.transform);
            var slot = slotObj.GetComponent<Slot>();
            slot.Init(i + 1);
            slot.OnTap = OnSlot;

            //�X���b�g�ɃA�C�e�����Z�b�g
            if (i < allItems.Length)
            {
                slot.SetItem(allItems[i]);
            }
            else
            {
                slot.SetItem(null);
            }

            slotList.Add(slot);
        }
    }

    public void OnSlot(Slot slot)
    {

        slot?.OnSelect();
    }

}
