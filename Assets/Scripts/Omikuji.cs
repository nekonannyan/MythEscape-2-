using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omikuji : MonoBehaviour
{
    [SerializeField]
    Item.Type clearItem = default;

    public GameObject omikujiCode = default;

    public void OnClickObj()
    {
        Debug.Log("OnClick");

        bool omikuji = ItemBox.instance.TryUseItem(clearItem);
        if (omikuji == true)
        {
            Debug.Log("ÉMÉ~ÉbÉNâèú");
            gameObject.SetActive(false);
            omikujiCode.SetActive(true);

        }
    }
}
