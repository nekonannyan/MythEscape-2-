using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//à⁄ìÆÇÃèàóù
public class Movement : MonoBehaviour
{
    //âEÇÃå¿äE
    private int RightMax = -1000;
    //ç∂ÇÃå¿äE
    private int LeftMax = 2000;

    //private int Expansion = 1500;
    //YÇÃà íu
    private int PositionY = 0;
    //XÇÃà íu
    private int PositionX = 1500;


    public void OnRightArrow()
    {
        if (PositionX == -1500 || PositionX == 1500)
        {
            return;
        }

        if (PositionY == RightMax)
        {
            PositionY = LeftMax;
            this.transform.localPosition = new Vector2(PositionY, PositionX);
        }

        else
        {
            PositionY = PositionY - 1000;
            this.transform.localPosition = new Vector2(PositionY, PositionX);
        }
    }

    public void OnLeftArrow()
    {
        if (PositionX == -1500 || PositionX == 1500)
        {
            return;
        }

        if (PositionY == LeftMax)
        {
            PositionY = RightMax;
            this.transform.localPosition = new Vector2(PositionY, PositionX);
        }
        else
        {
            PositionY = PositionY + 1000;
            this.transform.localPosition = new Vector2(PositionY, PositionX);
        }
    }

    public void OnFrontArrow()
    {
        PositionX = PositionX - 3000;
        this.transform.localPosition = new Vector2(PositionY, PositionX);
    }
    public void OnDown()
    {
        PositionX = PositionX + 1500;
        this.transform.localPosition = new Vector2(PositionY, PositionX);
    }
    public void OnUp()
    {
        PositionX = PositionX - 1500;
        this.transform.localPosition = new Vector2(PositionY, PositionX);
    }

    public void OnBackArrow()
    {
        PositionX = PositionX + 3000;
        this.transform.localPosition = new Vector2(PositionY, PositionX);

    }
}

