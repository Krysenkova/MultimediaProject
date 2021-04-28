using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableScript : MonoBehaviour

{
    public Transform myPrefab;
    private int prefabNumber;
    public Collider[] colliders;
    public float radius;

    void Start()
    {
        prefabNumber = Random.Range(10, 20);
        for (int i = 0; i < prefabNumber; i++)
        {
            Vector3 newPosition = new Vector3(Random.Range(-4, 4), 0.3f, Random.Range(-4, 4));
            Instantiate(myPrefab, newPosition, Quaternion.identity);

        }
    }

}
