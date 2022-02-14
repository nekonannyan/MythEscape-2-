using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    [SerializeField]
    Item.Type itemType;

    Item item;
    private void Start()
    {
        item = ItemGenerater.instance.Spawn(itemType);
    }
    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        //ÉNÉäÉbÉNÇµÇΩÇÁè¡Ç¶ÇÈ
        gameObject.SetActive(false);
    }

}
