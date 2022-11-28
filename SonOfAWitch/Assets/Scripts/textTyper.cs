using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class textTyper : MonoBehaviour
{
    public float letterPause = 0.2f;
    //  public AudioClip typeSound1;
    //public AudioClip typeSound2;
    public int textNum;
    string message;
    public TMP_Text textComp;

    // Use this for initialization
    void Start()
    {
        //textComp = GetComponent<TextMeshPro>();
        message = textComp.text;
        textComp.text = "";
        StartCoroutine(TypeText());
        //StartCoroutine(waitTime());
        //if (Input.GetMouseButtonDown(0) && textNum == 8)
          //  SceneManager.LoadScene(2);

    }

    IEnumerator waitTime()
    {
        
            
            yield return new WaitForSeconds(10);
      //  while(true)
        //{
       //     if (Input.GetMouseButtonDown(0) && textNum == 8)
        ///    SceneManager.LoadScene(2);
       // }

    }

    IEnumerator TypeText()
    {
        foreach (char letter in message.ToCharArray())
        {
            textComp.text += letter;
            //if (typeSound1 && typeSound2)
            //    SoundManager.instance.RandomizeSfx(typeSound1, typeSound2);
            yield return 0;
            yield return new WaitForSeconds(letterPause);
        }
    }

}
