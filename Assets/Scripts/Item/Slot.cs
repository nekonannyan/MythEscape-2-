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

    public Item GetItem()
    {
        return item;
    }

    //アイテムを表示
    void UpdateImage(Item item)
    {
        itemSlot.color = Color.white;
        image.sprite = item.sprite;
    }

    //選択したときにアイテムの色を変える
    public bool OnSelected()
    {
        if (item == null)
        {
            return false;
        }
        itemSlot.color = Color.gray;
        return true;
    }

    //色を戻す
    public void HideBgPanel()
    {
        if (item == null)
        {
            itemSlot.color = Color.clear;
            Debug.Log("アイテムがない所の色を戻す");
        }
        else
        {
            itemSlot.color = Color.white;
            Debug.Log("アイテムが入ってる所の選択解除");
        }
    }
}
