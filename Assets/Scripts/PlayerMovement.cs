using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float playerSpeed = 3f;
    private float rotate;
    float moveHorizontal;
    float moveVertical;
    float angle;
    public GameObject player;
    public Transform target;
    int score = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");

        angle += moveHorizontal * 0.01f * Time.deltaTime;

        Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0, Mathf.Cos(angle));

        Vector3 forwardDirection = Vector3.forward * playerSpeed;
        Vector3 rightDirection = Vector3.right * playerSpeed;
        //to move along x Axis(vertically)
        transform.Translate(rightDirection * Time.deltaTime * moveHorizontal * playerSpeed);
        //to move horizontally                             
        transform.Translate(forwardDirection * Time.deltaTime * moveVertical * playerSpeed);


        if (Input.GetKey(KeyCode.L))
        {
            
           //transform.rotation *= Quaternion.Euler(0,1,0);

            //transform.Rotate(Vector3.up * Time.deltaTime * rotationSpeed);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Collectable"))
        {
            other.gameObject.SetActive(false);
            score++;
            Debug.Log("Score: " + score);
        }
    }
}
