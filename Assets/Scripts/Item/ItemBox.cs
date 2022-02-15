using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    [SerializeField] Slot selectedSlot = null;

   // bool selected = false;

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
    //�X���b�g�I�����Ɏ��s����
    public void OnSelectSlot(int position)
    {
        foreach(Slot slot in slots)
        {
            slot.HideBgPanel();
        }

        //�I������Ă���A�C�e�����O���[�ɂ���
        if(slots[position].OnSelected())
        {
            selectedSlot = slots[position];
        }

        //if ( == true)
        //{
        //    ZoomItem.instance.ShowPanel();
        //}
    }

    //�A�C�e���̎g�p�����݂�
    public bool TryUseItem(Item.Type type)
    {
        if(selectedSlot == null)
        {
            return false;
        }

        if(selectedSlot.GetItem().type == type)
        {
            selectedSlot.HideBgPanel();
            selectedSlot = null;
            return true;
        }

        return false;
    }

    public Item GetSelectedItem()
    {
        if(selectedSlot == null)
        {
            return null;
        }
        return selectedSlot.GetItem();
    }
}