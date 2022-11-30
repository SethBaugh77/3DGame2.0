using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class playerTouchLight : MonoBehaviour
{
    public GameObject player;
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((player.transform.position.x - transform.position.x < 1.2 && player.transform.position.x - transform.position.x > -1.2) && (player.transform.position.z - transform.position.z < 1.2 && player.transform.position.z - transform.position.z > -1.2))
        {
            print("Honey");
            gameManager.SendMessage("goToLevel2");
        }
    }
}
