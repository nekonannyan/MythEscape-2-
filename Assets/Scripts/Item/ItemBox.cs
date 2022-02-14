using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots ;
    [SerializeField] Slot selectedSlot = null;

    //�ǂ��ł����s�o����悤�ɂ���
    public static ItemBox instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    //�X���b�g�ɃA�C�e��������
    public void SetItem(Item item)
    {
        //�A�C�e�������񂹂œ����
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