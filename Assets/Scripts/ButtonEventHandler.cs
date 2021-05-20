using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ButtonEventHandler : MonoBehaviour
{
    public Transform target;
    public float playerSpeed = 2f;
    float angle;
   
    private bool up = false;
    private bool down = false;
    private bool left = false;
    private bool right = false;

    /// <summary>
    /// Called when the scene is loaded
    /// </summary>
    void Start()
    {// Search for all Children from this ImageTarget with type VirtualButtonBehaviour
        VirtualButtonBehaviour[] vbs = GetComponentsInChildren<VirtualButtonBehaviour>();
        for (int i = 0; i < vbs.Length; ++i)
        {
            // Register with the virtual buttons TrackableBehaviour
            vbs[i].RegisterOnButtonPressed(OnButtonPressed);
            vbs[i].RegisterOnButtonReleased(OnButtonReleased);
        }

    }
    void Update()
    {

        if (up)
        {
            Debug.Log("Going UUUUUUUp");
            target.position += target.forward * Time.deltaTime * playerSpeed;
        }
        if (down)
        {
            Debug.Log("Going Down");
            target.position += -target.forward * Time.deltaTime * playerSpeed;
        }
        if (left)
        {
            Debug.Log("Rotate Left");
            angle += -0.01f * 0.5f * Time.deltaTime;
            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));
            target.localRotation = Quaternion.LookRotation(targetDirection);
        }
        if (right == true)
        {
            Debug.Log("Rotate Right");
            angle += 0.01f * 0.5f * Time.deltaTime;
            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));
            target.localRotation = Quaternion.LookRotation(targetDirection);
        }

    }
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "btn_down":
                Debug.Log("Pressed Down");
                down = true;
                up = false;
                left = false;
                right = false;
                break;
            case "btn_up":
                Debug.Log("Pressed Up");
                up = true;
                left = false;
                right = false;
                down = false;
                break;
            case "btn_left":
                Debug.Log("Pressed Left");
                left = true;
                up = false;
                right = false;
                down = false;
                break;
            case "btn_right":
                Debug.Log("Pressed Right");
                up = false;
                left = false;
                right = true;
                down = false;
                break;
        }
    }
    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "btn_down":
                Debug.Log("Released Down");
                down = false;
                break;
            case "btn_up":
                Debug.Log("Released Up");
                up = false;
                break;
            case "btn_left":
                Debug.Log("Released Left");
                left = false;
                break;
            case "btn_right":
                Debug.Log("Released Right");
                right = false;
                break;
        }
    }
}
