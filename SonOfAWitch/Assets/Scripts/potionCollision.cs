using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;

public class potionCollision : MonoBehaviour
{
   public GameObject potionExplosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator waitAFew(GameObject newPotionExplosion)
    {

        yield return new WaitForSeconds(2.5f);
        Destroy(newPotionExplosion);
    }


    private void OnCollisionEnter(Collision collision)
    {
        print("kekw");
        
        if (collision.gameObject.tag == "Witch")
        {
            Vector3 location = transform.position;
            GameObject newPotionExplosion = Instantiate(potionExplosion, location, Quaternion.identity);
            Destroy(this.gameObject);
            StartCoroutine(waitAFew(newPotionExplosion));
            
           

        }
        else if(collision.gameObject.tag == "Anything")
        {
            Vector3 location = transform.position;
            GameObject newPotionExplosion = Instantiate(potionExplosion, location, Quaternion.identity);
            Destroy(this.gameObject);
            StartCoroutine(waitAFew(newPotionExplosion));
        }
        
        

        




        
            
    }
}
