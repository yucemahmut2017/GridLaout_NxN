using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CreatGrid : MonoBehaviour
{



 


    public List<Button> _buttons;



    public int scrore;




    string downTo;
    string upTo;
    string leftTo;
    string rightTo;

    Neighbor neighbor;
    public List<Neighbor> neighborList;

    GridApp gridApp;
   





    private void Start()
    {


        gridApp = GameObject.Find("GridApp").GetComponent<GridApp>();

        gridApp.viewModel.GetCloumnSize().text = 4.ToString();//Grid has been assigned an initial value.

        gridApp.viewModel.GetWarningText().gameObject.SetActive(false);


        ReloadGrid();

    }



    public void ReloadGrid()

    {
        scrore = 0;
        if (gridApp.viewModel.GetWarningText().gameObject.activeInHierarchy)
        {
            gridApp.viewModel.GetWarningText().gameObject.SetActive(false);

        }
        GameObject[] killAll;
        killAll = GameObject.FindGameObjectsWithTag("myTag");
        for (int i = 0; i < killAll.Length; i++)
        {
            Destroy(killAll[i].gameObject);
        }
        neighbor = null;
        neighborList = null;
        neighborList = new List<Neighbor>();
        _buttons = null;
        _buttons = new List<Button>();
     
            for (int i = 0; i < Int32.Parse(gridApp.viewModel.GetCloumnSize().text); i++)
            {
                GameObject go = (GameObject)Instantiate(gridApp.viewModel.GetMyPrefab());

                go.transform.parent = transform;
                for (int j = 0; j < Int32.Parse(gridApp.viewModel.GetCloumnSize().text); j++)
                {



                    Button btn = (Button)Instantiate(gridApp.viewModel.GetButton());

                    btn.GetComponent<Image>().sprite = gridApp.viewModel.GetNormalSprite();
                    btn.transform.parent = go.transform;
                    btn.name = "button" + "[" + i + "]" + "[" + j + "]";
                    //rightBtn
                    if (j + 1 >= Int32.Parse(gridApp.viewModel.GetCloumnSize().text))
                    {
                        rightTo = "no";
                    }
                    else
                    {
                        int indisDeger = j + 1;
                        rightTo = "button" + "[" + i + "]" + "[" + indisDeger + "]";
                        //[j+1][i] right button

                    }
                    //leftBtn
                    if (j - 1 < 0)
                    {
                        leftTo = "no";
                    }
                    else
                    {
                        int indexValue = j - 1;
                        leftTo = "button" + "[" + i + "]" + "[" + indexValue + "]";
                        //[j-1][i] leftBtn button
                    }
                    if (i - 1 < 0)
                    {
                        upTo = "no";
                        //ben [i][j]
                        //[i-1][j] up button
                    }
                    else
                    {
                        int indisDeger = i - 1;
                        upTo = "button" + "[" + indisDeger + "]" + "[" + j + "]";
                    }
                    if (i + 1 >= Int32.Parse(gridApp.viewModel.GetCloumnSize().text))
                    {
                        downTo = "no";
                    }
                    else
                    {
                        int indisDeger = i + 1;
                        downTo = "button" + "[" + indisDeger + "]" + "[" + j + "]";
                        //[i+1][j] down button
                    }




                    neighbor = new Neighbor(btn, rightTo, leftTo, downTo, upTo);
                    neighborList.Add(neighbor);

                    _buttons.Add(btn);





            }
        }
      

    }
}

