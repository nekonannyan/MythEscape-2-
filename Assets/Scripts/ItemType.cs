using UnityEngine;
using System;

[Serializable]
public class ItemType
{
    //��ނ̗�
    public enum Type
    {
        Cube,
        Ball,
    }

    public Type type;       //���
    public Sprite sprite;   //�摜
}
