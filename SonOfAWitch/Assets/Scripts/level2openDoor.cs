using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class level2openDoor : MonoBehaviour
{
    public GameObject player;
    public GameObject sceneManager;

    public GameObject doorText;

    public GameObject gameManager;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((player.transform.position.x - transform.position.x < 1.0 && player.transform.position.x - transform.position.x > -1.0) && (player.transform.position.z - transform.position.z < 1.0 && player.transform.position.z - transform.position.z > -1.0) && level2Manager.invis == true)
        {
            doorText.gameObject.SetActive(true);

            if (Input.GetMouseButton(0))
            {
                gameManager.SendMessage("goToLevel3");
            }
            }
        else
            doorText.gameObject.SetActive(false);



    }
    
}
