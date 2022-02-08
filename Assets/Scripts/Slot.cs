using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    private Item item;

    [SerializeField]
    private GameObject slotGridPrefad;

    [SerializeField]
    private Image itemImage;
    [SerializeField]
    private Image bigItemImage = null;

    private  int clickCount = 0;

    public Item Item { get => item; }
    private int index;

    public System.Action<Slot> OnTap;

    public void Init(int index)
    {
        this.index = index;
        //gameObject.GetComponent<Button>().onClick.AddListener(OnItemBox);
    }

    public void OnItemBox()
    {
        this.OnTap?.Invoke(this);
    }

    public void OnSelect()
    {
        GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("slot");
        if (this.item != null && itemImage.color == Color.gray)
        {
            bigItemImage.gameObject.SetActive(true);
            bigItemImage.sprite = this.item.MyBigItemImage;
        }
        else if(this.item != null)
        {
            
            itemImage.color = new Color(0, 0, 0, 0);
            bigItemImage.gameObject.SetActive(false);
            itemImage.color = Color.gray;
        }
        else
        {
            itemImage.color = new Color(0, 0, 0, 0);
        }

        clickCount = index;
        Debug.Log("スロットの" + index);
    }

    public void SetItem(Item item)
    {
        this.item = item;//画像を表示

        if (this.item != null)
        {
            itemImage.sprite = this.item.MyItemImage;
            itemImage.color = new Color(1, 1, 1, 1);
        }
        else
        {
            itemImage.color = new Color(0, 0, 0, 0);
        }
    }

    private void OnDestroy()
    {
        this.OnTap = null;
    }
}
