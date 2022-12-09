using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class myPotionCollision : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject potionExplosion;
    public GameObject sceneManager;
    public AudioSource[] audio = new AudioSource[3];
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

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
        print("card");
       

        if (collision.gameObject.tag == "Witch")
        {
            print("Player");
            sceneManager.SendMessage("witchHit");
            StartCoroutine(waitAFew());


        }


        else if (collision.gameObject.tag == "Anything")
        {

            print("Anything");
            StartCoroutine(waitAFew());

        }















    }
}
