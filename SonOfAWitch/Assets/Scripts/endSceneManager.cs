using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endSceneManager : MonoBehaviour
{
    // Start is called before the first frame update
    public List<GameObject> texts;
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
            if (textNum == 6)
            {
                PlayerPrefs.SetInt("level", 0);
                gameManager.SendMessage("goToMainMenu");
                //SceneManager.LoadScene(2);
                return;
            }
            texts[textNum].SetActive(false);
            texts[textNum + 1].SetActive(true);
            textNum++;
            currTime = 2;


        }





    }
}
