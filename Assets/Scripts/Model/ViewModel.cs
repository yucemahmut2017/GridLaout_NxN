using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModel : MonoBehaviour
{



    public GameObject myprefabs;

    public Button btnn;


    public InputField cloumnSize;


    public Text warningText;

    public Sprite _sprite;


    public Sprite normalSprite;


    public Text scoreText;


    public Button GetButton()
    {

        return btnn;
    }

    public GameObject GetMyPrefab()
    {

        return myprefabs;
    }
    public InputField GetCloumnSize()
    {

        return cloumnSize;
    }
    public Sprite GetNormalSprite()
    {

        return normalSprite;
    }

    public Text GetScoreText()
    {

        return scoreText;
    }
    public Text GetWarningText()
    {

        return warningText;
    }
      public Sprite GetSprite()
    {

        return _sprite;
    }

}
   

