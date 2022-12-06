using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class spawnPotionsForPlayer : MonoBehaviour
{
    public GameObject potion;


    public int randomSeed;
    public float minSpawnTime;
    public float maxSpawnTime;


    public GameObject[] spawnPoints;


    private int spawnPoint;


    public static bool spot0Occupied = false;
    public static bool spot1Occupied = false;
    public static bool spot2Occupied = false;
    public static bool spot3Occupied = false;



    public static float currSpawnTime;

    // Start is called before the first frame update
    void Start()
    {
        Random.InitState(Random.Range(0, 100000));
        currSpawnTime = maxSpawnTime;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (spot0Occupied == true && spot1Occupied == true && spot2Occupied == true && spot3Occupied == true)
            return;
        if (currSpawnTime >= 0.0f)
        {
            currSpawnTime -= Time.deltaTime;
            return;
        }
        spawnPoint = Random.Range(0, 4);
        
       
        spawnPotion();


    }


    void spawnPotion()
    {

        if (spawnPoint == 0 && spot0Occupied == false)
        {
            
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = spawnPoints[0].transform.position;

            GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
            newPotion.SendMessage("chooseSpot", "0");
            spot0Occupied = true;
        }
        else if (spawnPoint == 1 && spot1Occupied == false)
        {
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = spawnPoints[1].transform.position;

            GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
            newPotion.SendMessage("chooseSpot", "1");
            spot1Occupied = true;
        }
        else if (spawnPoint == 2 && spot2Occupied == false)
        {
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = spawnPoints[2].transform.position;

            GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
            newPotion.SendMessage("chooseSpot", "2");
            spot2Occupied = true;
        }
        else if (spawnPoint == 3 && spot3Occupied == false)
        {
            currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
            Vector3 location = spawnPoints[3].transform.position;

            GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
            newPotion.SendMessage("chooseSpot", "3");
            spot3Occupied = true;
        }
    }









}
