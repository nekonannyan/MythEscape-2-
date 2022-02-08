using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]
    private Item[] allitem;


    public void OnClickObj()
    {
        //allitem‚Ì’†‚É“ü‚é
                                            
        //ƒNƒŠƒbƒN‚µ‚½‚çÁ‚¦‚é
        gameObject.SetActive(false);
    }

}
