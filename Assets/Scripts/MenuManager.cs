using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public GameObject canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvas.gameObject.activeInHierarchy == false)
            {
                canvas.SetActive(true);
                Time.timeScale = 0;
            }
            else
            {
                canvas.SetActive(false);
                Time.timeScale = 1;
            }
          
        }
    }

    public void restartButtonPressed()
    {
        Debug.Log("RESTART");
        SceneManager.LoadScene("Scene-Abgabe3");
        
        

    }

    public void returnButtonPressed()
    {
        Debug.Log("RETURN");
        canvas.SetActive(false);
        Time.timeScale = 1f;
       
    }

}
