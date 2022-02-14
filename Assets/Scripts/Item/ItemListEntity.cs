using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "ItemsL/ItemList")]
public class ItemListEntity : ScriptableObject
{
    public List<Item> itemList = new List<Item>();
}
