using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]
    private Item[] allitem;


    public void OnClickObj()
    {
        //allitemの中に入る
                                            
        //クリックしたら消える
        gameObject.SetActive(false);
    }

}
