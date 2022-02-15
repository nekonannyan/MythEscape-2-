using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField]
    private Image itemSlot;
    [SerializeField]
    Image image = default;

    Item item = default;


    private void Awake()
    {
        image = GetComponent<Image>();
    }

    private void Start()
    {
        itemSlot.color = Color.clear;
    }

    //�A�C�e�������邩���ׂ�
    public bool IsEmpty()
    {
        if (item == null)
        {
            return true;
        }
        return false;
    }

    public void SetItem(Item item)
    {
        this.item = item;
        UpdateImage(item);
    }

    public Item GetItem()
    {
        return item;
    }

    //�A�C�e����\��
    void UpdateImage(Item item)
    {
        itemSlot.color = Color.white;
        image.sprite = item.sprite;
    }

    //�I�������Ƃ��ɃA�C�e���̐F��ς���
    public bool OnSelected()
    {
        if (item == null)
        {
            return false;
        }
        itemSlot.color = Color.gray;
        return true;
    }

    //�F��߂�
    public void HideBgPanel()
    {
        if (item == null)
        {
            itemSlot.color = Color.clear;
            Debug.Log("�A�C�e�����Ȃ����̐F��߂�");
        }
        else
        {
            itemSlot.color = Color.white;
            Debug.Log("�A�C�e���������Ă鏊�̑I������");
        }
    }
}
