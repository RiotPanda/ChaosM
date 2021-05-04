using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Shade : MonoBehaviour
{
   PlayerControls controls;

    public Animator AButtn;

    void Awake()
    {
       controls = new PlayerControls();
       controls.Gameplay.APressed.performed += ctx => APress();
       controls.Gameplay.ARelease.performed += ctx => ARelease();
    }

    void APress() 
    {
        AButtn.SetBool("Pressed", true);
    }

    void ARelease()
    {
        AButtn.SetBool("Pressed", false);
    }

    void OnEnable()
    {
       controls.Gameplay.Enable();
    }

    void OnDisable()
    {
       controls.Gameplay.Disable();
    }
}
