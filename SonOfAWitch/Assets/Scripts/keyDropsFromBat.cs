using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class keyDropsFromBat : MonoBehaviour
{
    public GameObject player;
    public GameObject sceneManager;
    public GameObject keyText;

    // Start is called before the first frame update
    void Start()
    {
        keyText.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {
            if(sceneManager.GetComponent<Level1Manager>().holding == "beetle")
            {
                keyText.SetActive(true);
                if (Input.GetMouseButton(0))
                {
                    sceneManager.SendMessage("pickUpItem", "key");
                    keyText.SetActive(false);
                    this.GetComponent<Rigidbody>().useGravity = true;
                    StartCoroutine(waitToFall());
                    



                    //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



                }



            }
        }
    }
    public AudioSource[] audio = new AudioSource[3];
    public IEnumerator waitToFall()
    {
        audio[1].Play();
        yield return new WaitForSeconds(1.1f);


        audio[2].Play();
        yield return new WaitForSeconds(1.5f);
        Destroy(this.gameObject);
        sceneManager.SendMessage("pickUpItem", "key");

    }









    }
