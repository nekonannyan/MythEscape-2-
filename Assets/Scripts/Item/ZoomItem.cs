using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomItem : MonoBehaviour
{
    [SerializeField]
    GameObject panel = default;

    //�ǂ��ł����s�o����悤�ɂ���
    public static ZoomItem instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

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
