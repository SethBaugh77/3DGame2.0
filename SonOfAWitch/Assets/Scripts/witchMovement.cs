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
    public int amount;
    private Transform currentTarget;
    private float timer = 0f;
    private Boolean change;
    public int witchNum;
    public int previous;
    public Boolean returning; 







    // Start is called before the first frame update
    void Start()
    {
        
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
            if (witchNum == 0)
                witch0();
            else if (witchNum == 1)
            {
                witch1();
                rotationWitch1();
            }
            else if (witchNum == 2)
                witch2();
            else if (witchNum == 3)
                witch3();
            print("DOES IT GET HERE???");

            

            
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
    void rotationWitch0()
    {
        if(amount == 4 && previous == 3)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);
            
        }
        else if (amount == 5 && previous == 4)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }

        else if (amount == 6 && previous == 5)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 7 && previous == 6)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }

        else if (amount == 6 && previous == 7)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }
        else if (amount == 5 && previous == 6)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y -90, transform.rotation.z);

        }
        else if (amount == 4 && previous == 5)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 8 && previous == 4)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 9 && previous == 8)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 10 && previous == 9)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 11 && previous == 10)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 12 && previous == 11)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 11 && previous == 12)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }
        else if (amount == 10 && previous == 11)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 9 && previous == 10)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 8 && previous == 9)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y +90 , transform.rotation.z);

        }
        else if (amount == 4 && previous == 8)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount ==2 && previous == 3)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);
            returning = true;

        }
       
        else if(amount == 1 && previous == 0 &&  returning)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);
            returning = false;
        }



        change = false;
    }
    //amount if where it's going
    void rotationWitch1()
    {
        if (amount == 2 && previous == 1)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 1 && previous == 2)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }

        else if (amount == 3 && previous == 1)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 4 && previous == 3)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }

        else if (amount == 5 && previous == 4)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }
        else if (amount == 5 && previous == 6)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }
        else if (amount == 7 && previous == 5)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 0 && previous == 7)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 1 && previous == 0)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 10 && previous == 9)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 11 && previous == 10)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 12 && previous == 11)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 11 && previous == 12)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);

        }
        else if (amount == 10 && previous == 11)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 9 && previous == 10)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 8 && previous == 9)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 90, transform.rotation.z);

        }
        else if (amount == 4 && previous == 8)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);

        }
        else if (amount == 2 && previous == 3)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y - 90, transform.rotation.z);
            returning = true;

        }

        else if (amount == 1 && previous == 0 && returning)
        {
            transform.Rotate(transform.rotation.x, transform.rotation.y + 180, transform.rotation.z);
            returning = false;
        }



















        change = false;
    }









    void witch0()
    {
        //previous = amount;
        print("amount" + amount);
        print("prevous" + previous);
        if (amount == 7)
        {
            previous = amount;
            amount = 6;
            
        }
        else if(amount == 6 && previous == 7)
        {
            previous = amount;
            amount = 5;
            
        }
        else if (amount == 5 && previous == 6)
        {
            previous = amount;
            amount = 4;
            
        }
        else if (amount == 4 && previous == 5)
        {
            previous = amount;
            amount = 8;
           
        }
        else if (amount == 12)
        {
            previous = amount;
            amount = 11;
        }

        else if(amount == 11 && previous == 12)
        {
            previous = amount;
            amount = 10;
        }
        else if(amount == 10 && previous == 11)
        {
            previous = amount;
            amount = 9;
        }
        else if (amount == 9 && previous == 10)
        {
            previous = amount;
            amount = 8;
        }
        else if (amount == 8 && previous == 9)
        {
            previous = amount;
            amount = 4;
        }
        else if (amount == 4 && previous == 8)
        {
            previous = amount;
            amount = 3;
        }
        else if (amount == 3 && previous == 4)
        {
            previous = amount;
            amount = 2;
        }
        else if (amount == 2 && previous == 3)
        {
            previous = amount;
            amount = 1;
        }
        else if (amount == 1 && previous == 2)
        {
            previous = amount;
            amount = 0;
        }





        else
        {
            previous = amount;
            amount++;
        }
                    change = true;
                    
                    currentTarget = movePoints[amount];
                
    }

    void witch1()
    {
        if(amount == 2 && previous == 1)
        {
            previous = amount;
            amount = 1;
        }
        else if (amount == 1 && previous == 2)
        {
            previous = amount;
            amount = 3;
        }

        else if (amount == 6 && previous == 5)
        {
            previous = amount;
            amount = 5;
        }
        else if (amount == 5 && previous == 6)
        {
            previous = amount;
            amount = 7;
        }
        else if (amount == 7 && previous == 5)
        {
            previous = amount;
            amount = 0;
        }



        else
        {
            previous = amount;
            amount++;
        }
        change = true;

        currentTarget = movePoints[amount];


    }
    void witch2()
    {

    }
    void witch3()
    {

    }


    void witch4()
    {

    }


    void Movement()
    {
        Vector3 changeY = currentTarget.position;
        print("Within Movement method: current target.position: " + currentTarget.position);
        changeY.y = .08f;
        transform.position = Vector3.MoveTowards(transform.position, changeY, speed * Time.deltaTime);
        if(change)
        rotationWitch0();


        //moveTo.y = 0;
        //transf//orm.position = moveTo;
        //transform.position.x = Vector3.MoveTowards(transform.position.x, currentTarget.position.x, speed * Time.deltaTime);
    }








}
