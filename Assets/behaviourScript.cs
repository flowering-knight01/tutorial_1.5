using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class behaviourScript : MonoBehaviour
{
  //the music used for clip 1 can be found here: https://opengameart.org/content/little-town 
  //the music used for clip 2 can be found here: https://opengameart.org/content/fun-is-infinite-at-agm

    public AudioClip musicClipOne;

    public AudioClip musicClipTwo;

    public AudioSource musicSource;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
     if (Input.GetKeyDown(KeyCode.W))
        {
          musicSource.clip = musicClipOne;
          musicSource.Play();
        }

     if (Input.GetKeyUp(KeyCode.W))
        {
          musicSource.Stop();
        }

     if (Input.GetKeyDown(KeyCode.R))
        {
          musicSource.clip = musicClipTwo;
          musicSource.Play();
        }

     if (Input.GetKeyUp(KeyCode.R))
        {
          musicSource.Stop();
        }

     if (Input.GetKeyDown(KeyCode.L))
        {
          musicSource.loop = true;
        }

     if (Input.GetKeyUp(KeyCode.L))
        {
          musicSource.loop = false;
        }   
      if (Input.GetKey("escape"))
        {
          Application.Quit();
        }
    }
}
