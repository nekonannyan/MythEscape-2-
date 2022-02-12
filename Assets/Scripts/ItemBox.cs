using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemBox : MonoBehaviour
{
    [SerializeField] Slot[] slots;
    //�ǂ��ł����s�o����悤�ɂ���
    public static ItemBox instance;
    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }
    //�X���b�g�ɃA�C�e��������
    public void SetItem(ItemType item)
    {
        slots[0].SetItem(item);
       // Debug.Log("Set");
    }
}
