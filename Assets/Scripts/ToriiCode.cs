using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//�{�^��3.2.3.3.1

public class ToriiCode : MonoBehaviour
{
    private int[] code = {3,2,3,3,1};
    private int count = 0;
    private bool onetime = false;

    //�{�^���P
    public void Code1()
    {
        if (1 == code[count])
        {
            count += 1;
            Debug.Log("OK");
        }
        else
        {
            count = 0;
            Debug.Log("NO");
        }
    }

    //�{�^���Q
    public void Code2()
    {
        if (2 == code[count])
        {
            count += 1;
            Debug.Log("OK");
        }
        else
        {
            count = 0;
            Debug.Log("NO");
        }
    }
    //�{�^���R
    public void Code3()
    {
        if (3 == code[count])
        {
            count += 1;
            Debug.Log("OK");
        }
        else
        {
            count = 0;
            Debug.Log("NO");
        }
    }

    //����{�^��
    public void Decision()
    {
        if (count == 5 && onetime == false)
        {
            onetime = true;
            Debug.Log("OK");
        }
        else
        {
            count = 0;
            Debug.Log("NO");
        }
    }

    //Text�\��
    public void ChangeEnabled1(Text textComponent)
    {
        if (onetime == false)
        {
            textComponent.enabled = false;
        }
        else
        {
            textComponent.enabled = true;   //Text��\��
            GameObject Fence = GameObject.Find("Fence");
            Destroy(Fence);    //�t�F���X������
        }
    }

}
