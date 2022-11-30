using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2Manager : MonoBehaviour
{
     public GameObject shoeImage;
     public GameObject pencilImage;
     public GameObject grassImage;
    public string holding = null;
    public int inStand = 0;



    public List<GameObject> texts;
    public GameObject panel;
    int textNum = 0;
    public float currTime = 1.5f;
    Boolean GameIsPaused = false;
    public GameObject pauseMenu;
    //public GameObject textMenuForPause;



    // Start is called before the first frame update
    void Start()
    {
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

        void placeItem(string item)
        {
            if (item == "material1")
            {
                holding = null;
                // material1Image.SetActive(false);
                inStand++;
            }
            else if (item == "material2")
            {
                holding = null;
                // material2Image.SetActive(false);
                inStand++;
                //material1Image.SetActive(false);
            }
            else if (item == "material3")
            {
                holding = null;
                // material3Image.SetActive(false);
                inStand++;
                //material1Image.SetActive(false);
            }

            if (inStand++ == 3)
                invisPotion();
        }






        





    


    public void invisPotion()
    {

    }
}