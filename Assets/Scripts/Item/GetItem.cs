using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetItem : MonoBehaviour
{
    //[SerializeField]
    //ItemType.Type item;
    [SerializeField]
    Item item;

    public void OnClickObj()
    {
        ItemBox.instance.SetItem(item);
        //�N���b�N�����������
        gameObject.SetActive(false);
    }

}
