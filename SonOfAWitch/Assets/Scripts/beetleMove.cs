using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class beetleMove : MonoBehaviour
{
    public Transform[] movePoints;
    public float speed;
    private int amount;
    private Transform currentTarget;
    private float timer = 0f;

    void Start()
    {
        //Rigidbody.constraints = RigidbodyConstraints.FreezePositionY | RigidbodyConstraints.FreezePositionZ;
         
        randoming();
    }

    void Update()
    {
        Movement();
        timer += Time.deltaTime;
        if (timer > 5.05f)
        {
            randoming();
            timer = 0f;
        }
    }

    void randoming()
    {
        amount = Random.Range(0, movePoints.Length);
        currentTarget = movePoints[amount];
    }

    void Movement()
    {
        Vector3 changeY =  currentTarget.position;
        changeY.y = .882f;
        transform.position = Vector3.MoveTowards(transform.position, changeY, speed * Time.deltaTime);
        
        

        //moveTo.y = 0;
        //transf//orm.position = moveTo;
        //transform.position.x = Vector3.MoveTowards(transform.position.x, currentTarget.position.x, speed * Time.deltaTime);
    }
}
