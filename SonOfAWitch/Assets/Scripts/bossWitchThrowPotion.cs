using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bossWitchThrowPotion : MonoBehaviour
{
    public GameObject potion;



    public int randomSeed;
    public float minSpawnTime;
    public float maxSpawnTime;


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

        if (currSpawnTime >= 0.0f)
        {
            currSpawnTime -= Time.deltaTime;
            return;
        }

        Vector3 location = transform.position;
        GameObject newPotion = Instantiate(potion, location, Quaternion.identity);
        newPotion.GetComponent<Rigidbody>().AddForce(gameObject.transform.forward * 9000);
        currSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);

    }











}
