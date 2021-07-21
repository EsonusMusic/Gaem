using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager Instance;
    public AudioClip ballCollision, menuSelect, menuHover, wallCollision;
    private AudioSource audioSrc;
    // Start is called before the first frame update
    void Awake()
    {
        Instance = this;
        DontDestroyOnLoad(this);
    }
    void Start()
    {
        //ballCollision = Resources.Load<AudioClip>("ballCollision");
        //menuSelect = Resources.Load<AudioClip>("menuSelect");
        //menuHover = Resources.Load<AudioClip>("menuHover");
        //wallCollision = Resources.Load<AudioClip>("wallCollision");

        audioSrc = GetComponent<AudioSource>();
    }
    public void PlaySound (string clip)
    {
        print("sound");
        switch (clip) 
        {
            case "ballCollision":
            audioSrc.PlayOneShot (ballCollision);
            break;
            case "menuSelect":
            audioSrc.PlayOneShot (menuSelect);
            break;
            case "menuHover":
            audioSrc.PlayOneShot (menuHover);
            break;
            case "wallCollision":
            audioSrc.PlayOneShot (wallCollision); print(wallCollision);
            break;
        }
    }
}
