using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//ボタン3.2.3.3.1

public class ToriiCode : MonoBehaviour
{
    bool count1 = false;
    bool count2 = false;
    bool count3 = false;
    bool count4 = false;
    bool count5 = false;

    bool onetime = false;//一回だけ行う

    //ボタン１
    public void Code1()
    {
        if (count4 == true)
        {
            count4 = false;
            count5 = true;
            Debug.Log("OK");
        }
        else
        {
            count1 = true;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
            Debug.Log("NO");
        }
    }

    //ボタン２
    public void Code2()
    {
        if (count1 == true)
        {
            count1 = false;
            count2 = true;
            Debug.Log("OK");

        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
            Debug.Log("NO");

        }
    }

    //ボタン３
    public void Code3()
    {
        if (count2 == true)
        {
            count2 = false;
            count3 = true;
            Debug.Log("OK");

        }
        else if (count3 == true)
        {
            count3 = false;
            count4 = true;
        }

        else
        {
            count1 = true;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
            Debug.Log("NO");

        }
    }

    //決定ボタン
    public void Decision()
    {
        if (count5 == true && onetime == false)
        {
            onetime = true;
            Debug.Log("OK");
        }
        else
        {
            count1 = false;
            count2 = false;
            count3 = false;
            count4 = false;
            count5 = false;
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
