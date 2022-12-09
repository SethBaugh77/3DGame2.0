using System.Collections;
using System.Collections.Generic;
//using UnityEditor.VersionControl;
using UnityEngine;

public class potionCollision : MonoBehaviour
{
   public GameObject potionExplosion;
    public GameObject sceneManager;

    public AudioSource[] audio = new AudioSource[3];


    public float spawnTime;

    public float currSpawnTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
        currSpawnTime -= Time.deltaTime;
            
        
    }
    IEnumerator waitAFew()
    {
        Vector3 location = transform.position;
        GameObject newPotionExplosion = Instantiate(potionExplosion, location, Quaternion.identity);
        //Destroy(this.transform.GetChild(0).gameObject);
        //Destroy(this.transform.GetChild(0).gameObject);


        print("taffy");
        yield return new WaitForSeconds(.5f);
        Destroy(newPotionExplosion.gameObject);
        Destroy(this.gameObject);
    }


    private void OnCollisionEnter(Collision collision)
    {

        audio[0].Play();

        print("Blog" + currSpawnTime);
        if (currSpawnTime >= 0.0f)
        {
            return;
        }

        print("card");
        currSpawnTime = spawnTime;

        if (collision.gameObject.tag == "Player")
        {
            print("Player");
            sceneManager.SendMessage("playerHit");
            StartCoroutine(waitAFew());
            

        }


        else if (collision.gameObject.tag == "Anything")
        {

            print("Anything");
            StartCoroutine(waitAFew());
           
        }




        
        
        

        




        
            
    }
}
