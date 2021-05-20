using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ButtonEventHandler : MonoBehaviour
{
    public Transform target;
    public float playerSpeed = 5f;
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
            target.position += target.forward * Time.deltaTime * playerSpeed;
        }
        if (down)
        {
            target.position -= target.forward * Time.deltaTime * playerSpeed;
        }
        if (left)
        {
            angle -= 0.01f * 0.5f * Time.deltaTime;
            Vector3 targetDirection = new Vector3(Mathf.Sin(angle), 0f, Mathf.Cos(angle));
            target.localRotation = Quaternion.LookRotation(targetDirection);
        }
        if (right == true)
        {
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
                down = true;
                break;
            case "btn_up":
                up = true;
                break;
            case "btn_left":
                left = true;
                break;
            case "btn_right":
                right = true;
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
                down = false;
                break;
            case "btn_up":
                up = false;
                break;
            case "btn_left":
                left = false;
                break;
            case "btn_right":
                right = false;
                break;
        }
    }
}
