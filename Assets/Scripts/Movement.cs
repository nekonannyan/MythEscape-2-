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
    private int PositionX = 0;
    //XÇÃà íu
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

