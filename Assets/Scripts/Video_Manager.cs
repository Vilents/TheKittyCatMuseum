using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class Video_Manager : MonoBehaviour
{
    public VideoPlayer video;
    public Image_Swap imageSwap;
   public void setVideoPlayer(Image_Swap inImageSwap)
    {
        video = inImageSwap.targetPlayer;
        imageSwap = inImageSwap;
    }
    public void pauseVideo()
    {
        if (video != null)
        {
            video.Pause();
        }
        if(imageSwap != null)
        {
            imageSwap.updateVisuals(false);
        }
    }
}
