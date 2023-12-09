using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_02 : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour Vb_01;
    public VirtualButtonBehaviour Vb_02;
    public VirtualButtonBehaviour Vb_03;


    // Start is called before the first frame update
    void Start()
    {
        Vb_01.RegisterOnButtonPressed(OnButtonPressed);
        Vb_01.RegisterOnButtonReleased(OnButtonReleased);

        Vb_02.RegisterOnButtonPressed(OnButtonPressed2);
        Vb_02.RegisterOnButtonReleased(OnButtonReleased2);

        Vb_03.RegisterOnButtonPressed(OnButtonPressed3);
        Vb_03.RegisterOnButtonReleased(OnButtonReleased3);

        //default
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(true);
    }

    public void OnButtonPressed2(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(true);
        cube.transform.Rotate(Vector3.down, 45f);
    }

    public void OnButtonPressed3(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(true);
        cube.transform.Rotate(Vector3.up, 45f);
    }

    public void OnButtonReleased(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(false);
    }

    public void OnButtonReleased2(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(false);
    }

    public void OnButtonReleased3(VirtualButtonBehaviour Vb)
    {
        cube.SetActive(false);
    }
}
