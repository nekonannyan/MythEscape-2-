using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField]
    private Image itemSlot;

    Image image;
    private void Awake()
    {
        image = GetComponent<Image>();
    }
    public void SetItem(ItemType item)
    {

        UpdateImage(item);
    }

    void UpdateImage(ItemType item)
    {
        itemSlot.color = Color.white;
        image.sprite = item.sprite;
    }
}
