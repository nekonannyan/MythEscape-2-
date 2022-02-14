using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Items/ItemData")]
public class ItemData : ScriptableObject
{

    [System.Serializable]

    public class ItemModel
    {
        
        public string name;
        public Item id;
        public Sprite image;
        public bool isBigItem;
        public GameObject upPrefab;

        public static ItemModel Dummy() => new ItemModel();

        public bool IsEmpty => string.IsNullOrEmpty(name);
    }

    [SerializeField]
    private List<ItemModel> itemList;

    //public ItemModel GetItem(Item.Type id)
    //{
    //    for (int i = 0; i < itemList.Count; i++)
    //    {
    //        Item item = itemList[i];
    //        if (item.id == id)
    //        {
    //            return item;
    //        }
    //    }
    //    return ItemModel.Dummy();
    //}
}