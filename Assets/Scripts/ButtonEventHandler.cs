using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
public class ButtonEventHandler : MonoBehaviour
{
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
    /// <summary>
    /// Called when the virtual button has just been pressed:
    /// </summary>
    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        switch (vb.VirtualButtonName)
        {
            case "btn1":
                // Do something
                break;
            case "btn2":
                // Do Something
                break;
        }
    }
    /// <summary>
    /// Called when the virtual button has just been released:
    /// </summary>
    public void OnButtonReleased(VirtualButtonBehaviour vb) { }
}

