using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomItem : MonoBehaviour
{
    [SerializeField]
    GameObject panel = default;

    //どこでも実行出来るようにする
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

    //閉じるボタンが押されたとき
    public void ClosePanel()
    {
        panel.SetActive(false);
    }
}
