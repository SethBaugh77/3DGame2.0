using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class throwPotion : MonoBehaviour
{
    
    public GameObject potion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(1) && level3Manager.holding == true)
        {
            Vector3 location = transform.position;

            GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
            newPotion.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 500);
            level3Manager.holding = false;
            
        }

    }
    
    
}
