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

    //アイテムがあるか調べる
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

    //アイテムを表示
    void UpdateImage(Item item)
    {
        itemSlot.color = Color.white;
        image.sprite = item.sprite;
    }

    public bool OnSelected()
    {
        if (item == null)
        {
            return false;
        }
        itemSlot.color = Color.gray;
        return true;
    }

    public void HideBgPanel()
    {
        if (item == null)
        {
            itemSlot.color = Color.clear;
            Debug.Log("ok");
        }
        else 
        { 
        itemSlot.color = Color.white;
        }
    }
}
