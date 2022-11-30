using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUpPencil : MonoBehaviour
{

    public GameObject player;
    public GameObject pickUpPencilText;
    public GameObject sceneManager;
    // Start is called before the first frame update
    void Start()
    {
        pickUpPencilText.gameObject.SetActive(false);
        //canvas.gameObject.SetActive(true);
        //canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
        //sceneManager = GameObject.FindGameObjectWithTag("SceneManager");
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1))
        {
            pickUpPencilText.gameObject.SetActive(true);
            //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = true;


            if (Input.GetMouseButton(0))
            {
                sceneManager.SendMessage("pickUpItem", "Pencil");
                pickUpPencilText.gameObject.SetActive(false);
                Destroy(this.gameObject);

                //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;



            }
        }
        else
            pickUpPencilText.gameObject.SetActive(false);
        //  canvas.gameObject.GetComponentInChildren<TMPro.TextMeshProUGUI>().enabled = false;
    }
}
