using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script made by drakeerv

public class CameraChange : MonoBehaviour
{
    public Camera FirstPerson;
    public Camera ThirdPerson;
    public int StartingCam;
    private int CurrentCamera;

    void Start()
    {
        if (StartingCam == 1)
        {
            ThirdPerson.enabled = false;
            FirstPerson.enabled = true;
        }
        if (StartingCam == 2)
        {
            ThirdPerson.enabled = true;
            FirstPerson.enabled = false;
        }
    }


    void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            ThirdPerson.enabled = true;
            FirstPerson.enabled = false;
            print("switching to third person");
        }
        if (Input.GetKeyDown("q"))
        {
            ThirdPerson.enabled = false;
            FirstPerson.enabled = true;
            print("switching to first person");
        }
    }
}
