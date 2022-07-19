using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class FullScreen_Toggle : MonoBehaviour
{
    public VideoPlayer targetPlayer;
    public RenderTexture targetTexture;
    public RawImage fullscreenImage;
    public RectTransform fullscreenTransform;
    public Image_Swap targetPlayPauseButton, returnPlayPauseButton;
    public FullScreen_Toggle targetToggle;

    //Switch to fullscreen mode
    public void fullScreen()
    {
        fullscreenImage.texture = targetTexture;
        fullscreenTransform.localPosition = new Vector3(0f, 0f, 0f);
        targetPlayPauseButton.targetPlayer = targetPlayer;
        targetPlayPauseButton.updateVisuals(targetPlayer.isPlaying);
        targetToggle.targetPlayPauseButton = returnPlayPauseButton;
    }

    //Switch to normalscreen mode
    public void normalScreen()
    {
        fullscreenImage.texture = null;
        fullscreenTransform.localPosition = new Vector3(-2000f, 0f, 0f);
        targetPlayPauseButton.updateVisuals(targetPlayer.isPlaying);
    }
}
