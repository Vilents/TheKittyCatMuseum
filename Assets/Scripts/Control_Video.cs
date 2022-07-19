using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Control_Video : MonoBehaviour, IPointerDownHandler, IPointerUpHandler 
{
    public VideoPlayer videoPlayer;
    public Slider slider;
    bool slide = false;

    public void OnPointerDown(PointerEventData a)
    {
        slide = true;
    }
    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)slider.value
                      * videoPlayer.frameCount;
        videoPlayer.frame = (long)frame;
        slide = false;
    }
    // Start is called before the first frame update
    public void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void Update()
    {
        //Check if the video player is playing
        if (!slide && videoPlayer.isPlaying)
        {
            slider.value = videoPlayer.frame
                           / (float)videoPlayer.frameCount;
        }
    }
}
