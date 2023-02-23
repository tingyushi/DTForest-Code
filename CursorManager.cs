using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorManager : MonoBehaviour
{
    public bool control;


    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if (control)
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            control = false;
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
            control = true;
            
        }   
    }
}
