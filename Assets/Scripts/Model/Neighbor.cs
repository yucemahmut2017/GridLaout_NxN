using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Neighbor : MonoBehaviour
{
    Button bntt;
    string rightBtn;
    string leftBtn;
    string downBtn;
    string upBtn;


    public Neighbor(Button bntt,string sag,string sol,string asagi,string yukari)
    {
        this.bntt = bntt;
        this.rightBtn = sag;
        this.leftBtn = sol;
        this.downBtn = asagi;
        this.upBtn = yukari;

   

    }


    public Button getBntt()
    {

        return bntt;
    }

    public string getRight()
    {

        return rightBtn;
    }

    public string getLeft()
    {

        return leftBtn;
    }
    public string getDown()
    {

        return downBtn;
    }
    public string getUp()
    {

        return upBtn;
    }
   
}
