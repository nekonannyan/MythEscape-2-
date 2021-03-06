using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//移動の処理
public class Movement : MonoBehaviour
{
    //右の限界
    private int RightMax = -1000;
    //左の限界
    private int LeftMax = 2000;

    //private int Expansion = 1500;
    //Yの位置
    private int PositionX = 0;
    //Xの位置
    private int PositionY = 1500;


    public void OnRightArrow()
    {
        if (PositionY == -1500 || PositionY == 1500)
        {
            return;
        }

        if (PositionX == RightMax)
        {
            PositionX = LeftMax;
            this.transform.localPosition = new Vector2(PositionX, PositionY);
        }

        else
        {
            PositionX -= 1000;
            this.transform.localPosition = new Vector2(PositionX, PositionY);
        }
    }

    public void OnLeftArrow()
    {
        if (PositionY == -1500 || PositionY == 1500)
        {
            return;
        }

        if (PositionX == LeftMax)
        {
            PositionX = RightMax;
            this.transform.localPosition = new Vector2(PositionX, PositionY);
        }
        else
        {
            PositionX += 1000;
            this.transform.localPosition = new Vector2(PositionX, PositionY);
        }
    }

    public void OnFrontArrow()
    {
        PositionY -= 3000;
        this.transform.localPosition = new Vector2(PositionX, PositionY);
    }
    public void OnDown()
    {
        PositionY += 1500;
        this.transform.localPosition = new Vector2(PositionX, PositionY);
    }
    public void OnUp()
    {
        PositionY -= 1500;
        this.transform.localPosition = new Vector2(PositionX, PositionY);
    }

    public void OnBackArrow()
    {
        PositionY += 3000;
        this.transform.localPosition = new Vector2(PositionX, PositionY);

    }
}

