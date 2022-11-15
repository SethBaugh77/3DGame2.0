using System.Collections;
using System.Collections.Generic;
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

    public IEnumerator waitToFall()
    {

        yield return new WaitForSeconds(2.6f);
        Destroy(this.gameObject);
        sceneManager.SendMessage("pickUpItem", "key");

    }









    }
