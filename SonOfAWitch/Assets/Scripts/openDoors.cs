using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class openDoors : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject sceneManager;
    public GameObject door;
    public GameObject doorText;
    // Start is called before the first frame update
    void Start()
    {
        doorText.SetActive(false);

    }
    public AudioSource[] audio = new AudioSource[1];
    public IEnumerator waitASec()
    {
        audio[0].Play();
        yield return new WaitForSeconds(1.1f);


        gameManager.SendMessage("goToLevel2");

    }

    // Update is called once per frame
    void Update()
    {
        if((door.transform.position.x - transform.position.x < 2 && door.transform.position.x - transform.position.x > -2) && (door.transform.position.z - transform.position.z < 2 && door.transform.position.z - transform.position.z > -2) && (sceneManager.GetComponent<Level1Manager>().holding == "key"))
                {
            doorText.SetActive(true);
            if (Input.GetMouseButton(0))
            {
                sceneManager.SendMessage("pickUpItem", "key");
                doorText.SetActive(false);
                //this.GetComponent<Rigidbody>().useGravity = true;
                StartCoroutine(waitASec());
               



                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



            }
            //if (sceneManager.GetComponent<Level1Manager>().holding == "key")
            //{
            //    doorText.SetActive(true);
            //    if (Input.GetMouseButton(0))
            //    {
            //        sceneManager.SendMessage("pickUpItem", "key");
            //        doorText.SetActive(false);
            //        //this.GetComponent<Rigidbody>().useGravity = true;
            //        //StartCoroutine(waitToFall());
            //        gameManager.SendMessage("goToLevel2");



            //        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



            //    }



            //}

        }
        else
            doorText.SetActive(false);

    }
}
