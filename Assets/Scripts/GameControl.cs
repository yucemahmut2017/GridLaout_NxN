using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{



   
    GridApp gridApp;
   
    void Start()
    {

        gridApp = GameObject.Find("GridApp").GetComponent<GridApp>();
    }


    public void GameKontrol(Button btn)
    {
       
        btn.GetComponent<Image>().sprite = gridApp.viewModel.GetSprite();
        int _count = 0;




        for (int i = 0; i < gridApp.creatGrid.neighborList.Count; i++)
        {
            if (btn == gridApp.creatGrid.neighborList[i].getBntt())
            {

                gridApp.creatGrid._buttons[i].interactable = false;


                if (gridApp.creatGrid.neighborList[i].getRight() != "no")//Is there a button on the right?
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getRight() == gridApp.creatGrid._buttons[kars].name)//Is there between the buttons on the right, bring your name
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {
                                AgainControl(gridApp.creatGrid._buttons[kars]);
                                _count++;


                            }
                            else
                            {
                                Debug.Log("right empty!");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("no button on the right");
                }




                if (gridApp.creatGrid.neighborList[i].getLeft() != "no")//is threre a button on left?
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getLeft() == gridApp.creatGrid._buttons[kars].name)//is there between the buttons on left, bring your name
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                _count++;
                                AgainControl(gridApp.creatGrid._buttons[kars]);

                            }
                            else
                            {
                                Debug.Log("leftBtn empty !");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("no button on the left");
                }



                if (gridApp.creatGrid.neighborList[i].getUp() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getUp() == gridApp.creatGrid._buttons[kars].name)
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                _count++;
                                AgainControl(gridApp.creatGrid._buttons[kars]);
                                Debug.Log("up full :)");
                            }
                            else
                            {
                                Debug.Log("up empty!");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("up empty:)");
                }





                if (gridApp.creatGrid.neighborList[i].getDown() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getDown() == gridApp.creatGrid._buttons[kars].name)
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                _count++;
                                AgainControl(gridApp.creatGrid._buttons[kars]);
                                Debug.Log("downBtn is full :)");
                            }
                            else
                            {
                                Debug.Log("down empty");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("down no button:)");

                }


                if (_count >= 2)
                {
                    gridApp.creatGrid.scrore++;
                  
                    for (int j = 0; j < gridApp.creatGrid._buttons.Count; j++)
                    {
                        gridApp.creatGrid._buttons[j].interactable = true;
                        gridApp.creatGrid._buttons[j].GetComponent<Image>().sprite = gridApp.viewModel.GetNormalSprite();
                    }
                }


            }

        }




    }



    private void AgainControl(Button btn)
    {


        int sayy = 0;




        for (int i = 0; i < gridApp.creatGrid.neighborList.Count; i++)
        {
            if (btn == gridApp.creatGrid.neighborList[i].getBntt())
            {

                gridApp.creatGrid._buttons[i].interactable = false;


                if (gridApp.creatGrid.neighborList[i].getRight() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getRight() == gridApp.creatGrid._buttons[kars].name)
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                sayy++;


                            }
                            else
                            {
                                Debug.Log("right empty");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("not button on the right");
                }




                if (gridApp.creatGrid.neighborList[i].getLeft() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getLeft() == gridApp.creatGrid._buttons[kars].name)
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                sayy++;


                            }
                            else
                            {
                                Debug.Log("leftBtn empty");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("no button on the left");
                }



                if (gridApp.creatGrid.neighborList[i].getUp() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getUp() == gridApp.creatGrid._buttons[kars].name)
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                sayy++;

                                Debug.Log("up is full :)");
                            }
                            else
                            {
                                Debug.Log("upp empty");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("there is no neighbor above:)");
                }





                if (gridApp.creatGrid.neighborList[i].getDown() != "no")
                {
                    for (int kars = 0; kars < gridApp.creatGrid._buttons.Count; kars++)
                    {
                        if (gridApp.creatGrid.neighborList[i].getDown() == gridApp.creatGrid._buttons[kars].name)     
                        {

                            if (!gridApp.creatGrid._buttons[kars].interactable)
                            {

                                sayy++;

                                Debug.Log("downBtn full :)");
                            }
                            else
                            {
                                Debug.Log("down empty");
                            }
                        }
                    }



                }
                else
                {
                    Debug.Log("there is no neighbor below:)");

                }

                Debug.Log(sayy);
                if (sayy >= 2)
                {
                    gridApp.creatGrid.scrore++;
                    gridApp.viewModel.scoreText.text = gridApp.creatGrid.scrore.ToString();
                    for (int j = 0; j < gridApp.creatGrid._buttons.Count; j++)
                    {
                        gridApp.creatGrid._buttons[j].interactable = true;
                        gridApp.creatGrid._buttons[j].GetComponent<Image>().sprite = gridApp.viewModel.GetNormalSprite();


                    }
                }


            }

        }



    }
}













