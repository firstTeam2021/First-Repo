using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{

    public Pooler coinPool;

    public float distanceBetweenCoins;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Coins(Vector3 startingPos){

        GameObject coin1 = coinPool.GetPooledObj();
        coin1.transform.position = startingPos;
        coin1.SetActive(true);

        GameObject coin2 = coinPool.GetPooledObj();
        coin2.transform.position = new Vector3(startingPos.x - distanceBetweenCoins, startingPos.y, startingPos.z);
        coin2.SetActive(true);

        
        GameObject coin3 = coinPool.GetPooledObj();
        coin3.transform.position = new Vector3(startingPos.x + distanceBetweenCoins, startingPos.y, startingPos.z);
        coin3.SetActive(true);


    }
}
