using System;
using System.Collections;
using System.Collections.Generic;
using System.Net;
using Unity.VisualScripting;
using UnityEngine;

public class witchMovement : MonoBehaviour
{

    //private int movingToward;
    //public string witchNum;
    //public Transform[] movePoints;
    ////public GameObject[] moveTo; 
    //public float speed;
    //private int amount;

    //private Transform currentTarget;
    //private float timer = 0f;

    public Transform[] movePoints;
    public float speed;
    private int amount;
    private Transform currentTarget;
    private float timer = 0f;
    private Boolean change;









    // Start is called before the first frame update
    void Start()
    {
        amount = 0;
        currentTarget = movePoints[amount];
        //currentTarget = movePoints[movingToward].transform;
        print(currentTarget.position.x);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();


        //if(currentTarget.position == transform.position)
        //{
        //    print("DOES IT GET HERE???");
        //    currentTarget = movePoints[amount++];
        //}



        if ((currentTarget.position.x - transform.position.x < .1 && currentTarget.position.x - transform.position.x > -.1) && (currentTarget.position.z - transform.position.z < .1 && currentTarget.position.z - transform.position.z > -.1))
        {
            print("DOES IT GET HERE???");

            change = true;
                amount++;
                currentTarget = movePoints[amount];

            
        }








        //((movePoints[].transform.position.x - transform.position.x < 1 && player.transform.position.x - transform.position.x > -1) && (player.transform.position.z - transform.position.z < 1 && player.transform.position.z - transform.position.z > -1)) // witch is not at target then keep moving
        //if ((moveTo[movingToward].transform.position.x - transform.position.x < .1 && moveTo[movingToward].transform.position.x - transform.position.x > .1) && (moveTo[movingToward].transform.position.z - transform.position.z < .1 && moveTo[movingToward].transform.position.z - transform.position.z > .1))    
        //{
        //    movingToward++;
        //    currentTarget = moveTo[movingToward].transform;

        //}


        //    else //calculate new target
        //{

        //}



    }
    void rotationDo()
    {
        if(amount == 3)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
            
        }
        change = false;
    }

    void Movement()
    {
        Vector3 changeY = currentTarget.position;
        print("Within Movement method: current target.position: " + currentTarget.position);
        changeY.y = .08f;
        transform.position = Vector3.MoveTowards(transform.position, changeY, speed * Time.deltaTime);
        if(change)
        rotationDo();


        //moveTo.y = 0;
        //transf//orm.position = moveTo;
        //transform.position.x = Vector3.MoveTowards(transform.position.x, currentTarget.position.x, speed * Time.deltaTime);
    }








}
