using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooler : MonoBehaviour
{
    public GameObject pooledObj;
    public int amountPooled;

    List<GameObject>  pooledObjects;
    // Start is called before the first frame update
    void Start()
    {
        int counter;
        pooledObjects = new List<GameObject>();

        for(counter = 1; counter< amountPooled; counter++){

            GameObject gameObj = (GameObject) Instantiate(pooledObj);
            gameObj.SetActive(false);
            pooledObjects.Add(gameObj);
        }
        
    }

   public GameObject GetPooledObj(){

       for(int i=0; i< pooledObjects.Count; i++){

           if(!pooledObjects[i].activeInHierarchy){

               return pooledObjects[i];
           }

       }

       GameObject gameObj = (GameObject) Instantiate(pooledObj);
       gameObj.SetActive(false);
       pooledObjects.Add(gameObj);
       return gameObj; 


   }
  
}
