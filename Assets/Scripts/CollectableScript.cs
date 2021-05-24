using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour

{
    public Transform myPrefab;
    private int prefabNumber;
    public int min;
    public int max;
    public float y;
    public float x1;
    public float x2;
    public float z1;
    public float z2;
    

    void Start()
    {
        prefabNumber = Random.Range(min, max);
        for (int i = 0; i < prefabNumber; i++)
        {
            var newCollectable = Instantiate(myPrefab, new Vector3(Random.Range(x1, x2), y, Random.Range(z1, z2)), Quaternion.identity);
            newCollectable.transform.parent = gameObject.transform;
                      //Instantiate(myPrefab, new Vector3(Random.Range(-0.45f, 0.32f), y, Random.Range(-0.28f,0.28f)), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }

 

}
