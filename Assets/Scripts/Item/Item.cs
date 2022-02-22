using UnityEngine;
using System;

[Serializable]
public class Item
{
    //��ނ̗�
    public enum Type
    {
        Pencil,
        Omikuzi,
        Matti,
    }

    public Type type;       //���
    public Sprite sprite;   //�摜
    public Sprite zoomImage;

    public Item(Type type, Sprite sprite, Sprite zoomImage)
    {
        this.type = type;
        this.sprite = sprite;
        this.zoomImage = zoomImage;
    }
}