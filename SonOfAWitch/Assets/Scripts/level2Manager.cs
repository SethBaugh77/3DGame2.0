using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Random = UnityEngine.Random;

public class level2Manager : MonoBehaviour
{
     public GameObject shoeImage;
     public GameObject pencilImage;
     public GameObject grassImage;


    public static bool invis;
    public GameObject invisText;
    public static string holding = "null";
    public int inStand = 0;



    public List<GameObject> texts;
    public GameObject panel;
    int textNum = 0;
    public float currTime = 1.5f;
    Boolean GameIsPaused = false;
    public GameObject pauseMenu;

    float currSpawnTime;

    public AudioSource[] audio = new AudioSource[3];


    //public GameObject textMenuForPause;



    // Start is called before the first frame update
    void Start()
    {
        currSpawnTime = 25;
        invis = false;
        invisText.SetActive(false);
        holding = null;
         shoeImage.SetActive(false);
         pencilImage.SetActive(false);
         grassImage.SetActive(false);
        PauseMenu.GameIsPaused = true;
        panel.SetActive(true);
        texts[0].SetActive(true);
        //pauseMenu.SendMessage("PauseButNoUI");

    }

    // Update is called once per frame
    void Update()
    {

        
        






        print("holding");
        print(level2Manager.holding);
        //print("holding" + holding.ToString());
        //texts[0].SetActive(true);
        //if (currTime >= 0.0f)
        //{
        //    currTime -= Time.deltaTime;
        //    return;
        //}

        if (Input.GetMouseButtonDown(0))
        {
            PauseMenu.GameIsPaused = false;
            panel.SetActive(false);
            texts[textNum].SetActive(false);
            // pauseMenu.SendMessage("ResumeButNoUI");

        }

        if (currSpawnTime >= 0.0f)
        {
            currSpawnTime -= Time.deltaTime;
            return;
        }

        audio[0].Play();
        currSpawnTime = Random.Range(10, 40);




    }
        void pickUpItem(string item)
        {

            if (item == "Shoe")
            {
                holding = "Shoe";
                 shoeImage.SetActive(true);
            }
            else if (item == "Pencil")
            {
                holding = "Pencil";
                 pencilImage.SetActive(true);
                //material1Image.SetActive(false);
            }
            else if (item == "Grass")
            {
                holding = "Grass";
                grassImage.SetActive(true);
                //material1Image.SetActive(false);
            }
        }

        void placeItem()
        {
            if (holding == "Shoe")
            {
                holding = null;
            shoeImage.SetActive(false);
                // material1Image.SetActive(false);
                inStand++;
            }
            else if (holding == "Grass")
            {
                holding = null;
            grassImage.SetActive(false);
            // material2Image.SetActive(false);
            inStand++;
                //material1Image.SetActive(false);
            }
            else if (holding == "Pencil")
            {
                holding = null;
            pencilImage.SetActive(false);
            // material3Image.SetActive(false);
            inStand++;
                //material1Image.SetActive(false);
            }

            if (inStand == 3)
                invisPotion();
        }

   














    public void invisPotion()
    {
        audio[1].Play();
        invisText.SetActive(true);
        invis = true;
    }
}