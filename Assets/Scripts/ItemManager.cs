using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    [SerializeField]
    private Item[] allitem;


    public void OnClickObj()
    {
        //allitem�̒��ɓ���
                                            
        //�N���b�N�����������
        gameObject.SetActive(false);
    }

}
