using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowManager : MonoBehaviour
{
    [Header("Main Menu")]
    public bool mainMenuBool = true;

    [Header("How do we feel?")]
    public bool hungry = false;
    public bool tired = false;

    [Header("Which Hungry Ad do we choose?")]
    public bool[] hungryAds = new bool[4];

    [Header("Which Tired Ad do we choose?")]
    public bool[] tiredAds = new bool[4];


    


    public GameObject[] _feeling;
    public GameObject[] _objectHungryAds = new GameObject[4];
    public GameObject[] _objectTiredAds = new GameObject[4];
    public GameObject[] _Milan;


    public GameObject _MainMenu;



    

    void Start()
    {
    
    }


    void Update()
    {
        _MainMenu.SetActive(mainMenuBool);


        if (hungry && tired == false)
        {
            //Debug.Log("hungry & tired are false");
            mainMenuBool = true;
            _MainMenu.SetActive(mainMenuBool);
        }


        

        if (hungry == true)
        {
            _feeling[0].SetActive(true);
            mainMenuBool = false;
            _MainMenu.SetActive(mainMenuBool);

        }

        else
        {
            _feeling[0].SetActive(false);

        }

        if (tired == true)
        {
            _feeling[1].SetActive(true);
            mainMenuBool = false;
        }

        else
        {
            _feeling[1].SetActive(false);
        }


        for (int i = 0; i < 4; i++)
        {
            if (hungryAds[i] == true)
            {
                _objectHungryAds[i].SetActive(true);
                mainMenuBool = false;
            }

            if (hungryAds[i] == false)
            {
                _objectHungryAds[i].SetActive(false);
                
            }

        }

        

    }

}
