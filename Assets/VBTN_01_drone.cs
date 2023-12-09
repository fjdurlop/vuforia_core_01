using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class VBTN_01_drone : MonoBehaviour
{
    public GameObject my_object;
    public VirtualButtonBehaviour Vb_01;
    public VirtualButtonBehaviour Vb_02;
    //public VirtualButtonBehaviour Vb_03;
    public GameObject vuforiaButton; // Reference to your Vuforia virtual button GameObject
    public GameObject vuforiaButton2; // Reference to your Vuforia virtual button GameObject
    //public GameObject vuforiaButton3; // Reference to your Vuforia virtual button GameObject

    public Material newMaterial;

    private Material originalMaterial;
    private Material originalMaterial2;
    //private Material originalMaterial3;

    private bool my_object_active = false;
    


    // Start is called before the first frame update
    void Start()
    {

        

        Renderer buttonRenderer = vuforiaButton.GetComponent<Renderer>();
        Renderer buttonRenderer2 = vuforiaButton2.GetComponent<Renderer>();
        //Renderer buttonRenderer3 = vuforiaButton3.GetComponent<Renderer>();

        // Renderer buttonRenderer2 = vuforiaButton2.GetComponent<Renderer>();
        // Renderer buttonRenderer3 = vuforiaButton3.GetComponent<Renderer>();

        originalMaterial = buttonRenderer.material;
        originalMaterial2 = buttonRenderer2.material;
        //originalMaterial3 = buttonRenderer3.material;

        //default
        my_object.SetActive(false);
        my_object_active = false;

        Vb_01.RegisterOnButtonPressed(OnButtonPressed);
        Vb_01.RegisterOnButtonReleased(OnButtonReleased);

        Vb_02.RegisterOnButtonPressed(OnButtonPressed);
        Vb_02.RegisterOnButtonReleased(OnButtonReleased);

        //Vb_03.RegisterOnButtonPressed(OnButtonPressed);
        //Vb_03.RegisterOnButtonReleased(OnButtonReleased);


    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }

    public void OnButtonPressed(VirtualButtonBehaviour Vb)
    {
        if(Vb.VirtualButtonName == "vbtn_drone_01")
        {
            if(!my_object_active)
            {
                my_object.SetActive(true);
                my_object_active = true;
            }else{
                my_object.SetActive(false);
                my_object_active = false;
            }
            
            //cube.transform.Rotate(Vector3.up, 45f);
            Renderer buttonRenderer = vuforiaButton.GetComponent<Renderer>();
            // Check if the button has a renderer
            if (buttonRenderer != null)
            {
                // Assign the new material to the button renderer
                buttonRenderer.material = newMaterial;
            }
        }
        else if(Vb.VirtualButtonName == "vbtn_drone_02")
        {
            //cube.SetActive(true);
            
            //cube.transform.Rotate(Vector3.up, 45f);
            Renderer buttonRenderer = vuforiaButton2.GetComponent<Renderer>();
            // Check if the button has a renderer
            if (buttonRenderer != null)
            {
                // Assign the new material to the button renderer
                buttonRenderer.material = newMaterial;
            }
            if(my_object_active){
                my_object.transform.Rotate(Vector3.up, 20f);
            }
            
        }
        // else if(Vb.VirtualButtonName == "vbtn_drone_03")
        // {
        //     Renderer buttonRenderer = vuforiaButton3.GetComponent<Renderer>();
        //     // Check if the button has a renderer
        //     if (buttonRenderer != null)
        //     {
        //         // Assign the new material to the button renderer
        //         buttonRenderer.material = newMaterial;
        //     }
        //     if(my_object_active){
        //         my_object.transform.Rotate(Vector3.down, 20f);
        //     }
        // }
        
    }

    public void OnButtonReleased(VirtualButtonBehaviour Vb)
    {

        if(Vb.VirtualButtonName == "vbtn_drone_01")
        {
            Renderer buttonRenderer = vuforiaButton.GetComponent<Renderer>();
            // Check if the button has a renderer
            if (buttonRenderer != null)
            {
                // Assign the new material to the button renderer
                buttonRenderer.material = originalMaterial;
            }
        }
        else if(Vb.VirtualButtonName == "vbtn_drone_02")
        {
            Renderer buttonRenderer = vuforiaButton2.GetComponent<Renderer>();
            // Check if the button has a renderer
            if (buttonRenderer != null)
            {
                // Assign the new material to the button renderer
                buttonRenderer.material = originalMaterial2;
            }
        }
        // else if(Vb.VirtualButtonName == "vbtn_drone_03")
        // {
        //     Renderer buttonRenderer = vuforiaButton3.GetComponent<Renderer>();
        //     // Check if the button has a renderer
        //     if (buttonRenderer != null)
        //     {
        //         // Assign the new material to the button renderer
        //         buttonRenderer.material = originalMaterial3;
        //     }
        // }
        
    }

}
