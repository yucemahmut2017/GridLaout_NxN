using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonModel


{


    Button myButton;

    int[] myArrayLeft;
    int[] myArrayright;
    int[] myarrayUp;
    int[] myarrayDown;
    int[] buttonpos;//Button position
    
    public ButtonModel(Button myButton,int[] buttonpos,int[] myArrayLeft, int[] myArrayright, int[] myarrayUp, int[] myarrayDown)
    {


        this.myArrayLeft = myArrayLeft;
        this.myArrayright = myArrayright;
        this.myarrayUp = myarrayUp;
        this.myarrayDown = myarrayDown;
        this.myButton = myButton;
        this.buttonpos = buttonpos;



    }

    public Button getButton()
    {
        return myButton;
    }
    public int[] getmyArrayLeft()
    {
        return myArrayLeft;
    }
    public int[] getmyArrayright()
    {
        return myArrayright;
    }

    public int[] getmyArrayUp()
    {
        return myarrayUp;
    }


    public int[] getmyButtonpos()
    {
        return buttonpos;
    }

    public int[] getmyArrayDown()
    {
        return myarrayDown;

    }


}
