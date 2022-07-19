using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class Image_Swap : MonoBehaviour
{
    public bool state = true;
    public Sprite onSprite, offSprite;
    public Image targetImage;
    public VideoPlayer targetPlayer;

    public void toggleState()
    {
        state = !state;
        processState(state);
    }

    public void processState(bool inState)
    {
        if (inState)
        {
            targetImage.sprite = onSprite;
            targetPlayer.Play();
        }
        else
        {
            targetImage.sprite = offSprite;
            targetPlayer.Pause();
        }
    }

    public void updateVisuals(bool inState)
    {
        state = inState;

        if (inState)
        {
            targetImage.sprite = onSprite;
        }
        else
        {
            targetImage.sprite = offSprite;
        }
    }

    public void Start()
    {
        processState(state);
    }
}
