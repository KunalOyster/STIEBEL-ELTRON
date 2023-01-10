using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OnlineVideoLoader : MonoBehaviour
{
    public string url;
    public VideoPlayer vidplayer;

    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();
        vidplayer.url = url;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.anyKey)
    //    {
    //        Play();
    //    }

    //}

   public void Play()
   {
        vidplayer.Play();
        vidplayer.isLooping = true;
   }
}