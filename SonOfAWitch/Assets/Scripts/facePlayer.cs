using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facePlayer : MonoBehaviour
{
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        //as players z location decreases, witches 
        //player initil location z = 4.811
        //witch initial rotation z = -.167
        //transform.localEulerAngles = new Vector3(-rotationY, rotationX, 0);
    }
}
