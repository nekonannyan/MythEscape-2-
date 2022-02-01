using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ボタン3.2.3.3.1

public class ToriiCode : MonoBehaviour
{
    private int[] code = {3,2,3,3,1};
    private int count = 0;
    private bool onetime = false;

    //ボタン１
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

    //ボタン２
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
    //ボタン３
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

    //決定ボタン
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

    //Text表示
    public void ChangeEnabled1(Text textComponent)
    {
        if (onetime == false)
        {
            textComponent.enabled = false;
        }
        else
        {
            textComponent.enabled = true;   //Textを表示
            GameObject Fence = GameObject.Find("Fence");
            Destroy(Fence);    //フェンスを消去
        }
    }

}
