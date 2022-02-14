using UnityEngine;
using System;

[Serializable]
public class Item
{
    //Ží—Þ‚Ì—ñ‹“
    public enum Type
    {
        Pencil,
        Omikuzi,
        Matti,
    }

    public Type type;       //Ží—Þ
    public Sprite sprite;   //‰æ‘œ
    
    public Item(Type type, Sprite sprite)
    {
        this.type = type;
        this.sprite = sprite;
    }
}