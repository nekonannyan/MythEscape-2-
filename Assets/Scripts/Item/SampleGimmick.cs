using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleGimmick : MonoBehaviour
{
    [SerializeField]
    Item.Type clearItem = default;

    public void OnClickObj()
    {
        Debug.Log("OnClick");

        bool Matti = ItemBox.instance.TryUseItem(clearItem);
        if (Matti == true)
        {
            Debug.Log("ギミック解除");
            gameObject.SetActive(false);
        }
    }
}
