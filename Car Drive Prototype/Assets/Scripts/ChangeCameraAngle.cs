using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCameraAngle : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public KeyCode keyCode;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            if (camera1.activeInHierarchy == false)
            {
                camera1.SetActive(true);
                camera2.SetActive(false);
            }
            else
            {
                camera1.SetActive(false);
                camera2.SetActive(true);
            }

        }
    }
}
