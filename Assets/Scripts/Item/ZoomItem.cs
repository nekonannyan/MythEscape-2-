using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoomItem : MonoBehaviour
{
    [SerializeField]
    GameObject panel = default;
    [SerializeField]
    Image setZoomImage = default;

    Sprite setZoom = default;



    public void ShowPanel()
    {
        Item item = ItemBox.instance.GetSelectedItem();
        if (item != null)
        {
            panel.SetActive(true);
        }
    }

    //����{�^���������ꂽ�Ƃ�
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
