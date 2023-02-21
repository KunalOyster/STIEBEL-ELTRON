using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class OnlineVideoLoader : MonoBehaviour
{
    public string url;
    public VideoPlayer vidplayer;
    public AudioSource audios;
    // Start is called before the first frame update
    void Start()
    {
        vidplayer = GetComponent<VideoPlayer>();
        vidplayer.url = url;
        audios = GetComponent<AudioSource>();
        vidplayer.prepareCompleted += Play;
    }

    // Update is called once per frame
    //void Update()
    //{
    //    if (Input.anyKey)
    //    {
    //        Play();
    //    }
    //}

    public void Play(VideoPlayer vp)
    {
        vidplayer.Play();
        Debug.Log("Playing an audio");
        audios.Play();
        vidplayer.isLooping = true;
    }
}