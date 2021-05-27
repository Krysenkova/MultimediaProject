using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableMovement : MonoBehaviour
   
{
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if(Time.timeScale == 1f)
            transform.Rotate(new Vector3(0f, 1f, 0f));
        
    }
}
