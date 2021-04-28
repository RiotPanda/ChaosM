using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.InputSystem;

public class Sound : MonoBehaviour
{
    PlayerControls controlsmusic;

    public AudioSource sourceA;
    public AudioClip clipA;
    public AudioSource sourceB;
    public AudioClip clipB;
    public AudioSource sourceX;
    public AudioClip clipX;
    public AudioSource sourceY;
    public AudioClip clipY;
    public AudioSource sourceLB;
    public AudioClip clipLB;
    public AudioSource sourceRB;
    public AudioClip clipRB;
    public AudioSource sourceLT;
    public AudioClip clipLT;
    public AudioSource sourceRT;
    public AudioClip clipRT;
    void Awake()
    {
        controlsmusic = new PlayerControls();
        controlsmusic.Gameplay.APressed.performed += ctx => Sound1();
        controlsmusic.Gameplay.BPressed.performed += ctx => Sound2();
        controlsmusic.Gameplay.XPressed.performed += ctx => Sound3();
        controlsmusic.Gameplay.YPressed.performed += ctx => Sound4();
        controlsmusic.Gameplay.LBPressed.performed += ctx => Sound5();
        controlsmusic.Gameplay.RBPressed.performed += ctx => Sound6();
        controlsmusic.Gameplay.LTPressed.performed += ctx => Sound7();
        controlsmusic.Gameplay.RTPressed.performed += ctx => Sound8();
    }

    void Sound1()
    {
        sourceA.PlayOneShot(clipA);
    }

    void Sound2()
    {
        sourceB.PlayOneShot(clipB);
    }

    void Sound3()
    {
        sourceX.PlayOneShot(clipX);
    }

    void Sound4()
    {
        sourceY.PlayOneShot(clipY);
    }

    void Sound5()
    {
        sourceLB.PlayOneShot(clipLB);
    }

    void Sound6()
    {
        sourceRB.PlayOneShot(clipRB);
    }

    void Sound7()
    {
        sourceLT.PlayOneShot(clipLT);
    }

    void Sound8()
    {
        sourceRT.PlayOneShot(clipRT);
    }

    void OnEnable()
    {
        controlsmusic.Gameplay.Enable();
    }

    void OnDisable()
    {
        controlsmusic.Gameplay.Disable();
    }
}

