using System.Collections;
//using System.Collections.Generic;
using UnityEngine;

public class PlatformsGenerator : MonoBehaviour
{

    public GameObject[] myPlatform;
    public Transform generatorPoint;
    public float distance;

    private float platformWidth;

    public float gapMin;
    public float gapMax;

    //public GameObject[] Platforms;
    private int platformSelect;
    private float[] Widths;

    public Pooler[] ObjPools;

    private CoinGenerator myCoinGenerator;

    public float randomCoins;
    // Start is called before the first frame update
    void Start()
    {
        
      //platformWidth = Platforms[platformSelect].GetComponent<BoxCollider2D>().size.x;

     Widths = new float[ObjPools.Length];

       for(int i = 0; i<ObjPools.Length;i++){

           Widths[i] = ObjPools[i].pooledObj.GetComponent<BoxCollider2D>().size.x;
       }

        
      myCoinGenerator = FindObjectOfType<CoinGenerator>();

      
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if(transform.position.x < generatorPoint.position.x){

             distance = Random.Range (gapMin, gapMax);

             platformSelect = Random.Range(0, ObjPools.Length);

             transform.position = new Vector3(transform.position.x + (Widths[platformSelect]/2) + distance, transform.position.y, transform.position.z);

             //transform.position = new Vector3(transform.position.x + platformWidth + distance, transform.position.y, transform.position.z);

             //platformSelect = Random.Range(0, Platforms.Length);

           // Instantiate (Platforms[platformSelect], transform.position, transform.rotation);


           GameObject newPlatform = ObjPools[platformSelect].GetPooledObj();

           newPlatform.transform.position = transform.position;
           newPlatform.transform.rotation = transform.rotation;
           newPlatform.SetActive(true);

           if(Random.Range(0f, 100f) < randomCoins){

             myCoinGenerator.Coins(new Vector3(transform.position.x, transform.position.y + 1f, transform.position.z));

            
            }

           


           transform.position = new Vector3(transform.position.x + (Widths[platformSelect]/2), transform.position.y, transform.position.z);
        }
        
    }
}
