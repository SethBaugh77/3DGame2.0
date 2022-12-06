using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginningSceneManager : MonoBehaviour
{
    //public GameObject text1;
    //public GameObject text2;
    public List <GameObject> texts;
    int textNum = 0;
    public static float currTime = 1.5f;


    public GameObject gameManager;


    // Start is called before the first frame update
    void Start()
    {
        texts[0].SetActive(true);
        
    }

    // Update is called once per frame
    void Update()
    {

        if (currTime >= 0.0f)
        {
            currTime -= Time.deltaTime;
            return;
        }






        if (Input.GetMouseButtonDown(0))
        {
            if (textNum == 8)
            {
                gameManager.SendMessage("goToLevel1");
                //SceneManager.LoadScene(2);
                return;
            }
            texts[textNum].SetActive(false);
            texts[textNum + 1].SetActive(true);
            textNum++;
            currTime = 2;


        }
        
        



    }

    //void pickUpItem(string item)
    //{
        
    //    if(item == "beetle")
    //    {
    //        holding = "beetle";
    //        BeetleImage.SetActive(true);
    //    }
    //    else if(item == "key")
    //    {
    //        holding = "key";
    //        keyImage.SetActive(true);
    //        BeetleImage.SetActive(false);
    //    }
    //}
}
