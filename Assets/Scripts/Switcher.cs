using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Switcher : MonoBehaviour
{
    public RectTransform tabbyShortDescription_Toggle, tuxedoShortDescription_Toggle, fluffyShortDescription_Toggle, title, main, details,
        tabbyLongDescription, tuxedoLongDescription, fluffyLongDescription;
    public ColorBlock buttonColors;
    public Toggle tabbyToggleTest, tuxToggleTest, fluffToggleTest;

    public void tapToBegin()
    {
        title.gameObject.SetActive(false);
    }
    public void tabbyToggle(bool inState)
    {
        Toggle tabbyToggle = tabbyToggleTest;
        ColorBlock tabbyColors = tabbyToggle.colors;
        tabbyColors.normalColor = inState ? buttonColors.selectedColor : buttonColors.normalColor;
        tabbyToggle.colors = tabbyColors;
        tabbyShortDescription_Toggle.localPosition = new Vector3(0f, 0f, 0f);
        fluffyShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
        tuxedoShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
    }
    public void tuxedoToggle(bool inState)
    {
        Toggle tuxToggle = tuxToggleTest;
        ColorBlock tuxColors = tuxToggle.colors;
        tuxColors.normalColor = inState ? buttonColors.selectedColor : buttonColors.normalColor;
        tuxToggle.colors = tuxColors;
        tuxedoShortDescription_Toggle.localPosition = new Vector3(0f, 0f, 0f);
        tabbyShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
        fluffyShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
    }
    public void fluffyToggle(bool inState)
    {
        Toggle fluffToggle = fluffToggleTest;
        ColorBlock fluffColors = fluffToggle.colors;
        fluffColors.normalColor = inState ? buttonColors.selectedColor : buttonColors.normalColor;
        fluffToggle.colors = fluffColors;
        fluffyShortDescription_Toggle.localPosition = new Vector3(0f, 0f, 0f);
        tabbyShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
        tuxedoShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
    }

    public void tabbyLong()
    {
        main.gameObject.SetActive(false);
        details.gameObject.SetActive(true);
        tabbyLongDescription.localPosition = new Vector3(0f, 0f, 0f);
        fluffyLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
        tuxedoLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
    }
    public void tuxedoLong()
    {
        main.gameObject.SetActive(false);
        details.gameObject.SetActive(true);
        tuxedoLongDescription.localPosition = new Vector3(0f, 0f, 0f);
        tabbyLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
        fluffyLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
    }
    public void fluffyLong()
    {
        main.gameObject.SetActive(false);
        details.gameObject.SetActive(true);
        fluffyLongDescription.localPosition = new Vector3(0f, 0f, 0f);
        tabbyLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
        tuxedoLongDescription.localPosition = new Vector3(-2000f, 0f, 0f);
    }

    public void back()
    {
        main.gameObject.SetActive(true);
    }

    public void toggleDefaultCat(Toggle inToggle)
    {
        inToggle.isOn = false;
        inToggle.isOn = true;
        inToggle.Select();
    }

    public void toggleExtras(Toggle inToggle)
    {
        bool inState = inToggle.isOn;
        Toggle tabbyToggle = inToggle;
        ColorBlock tabbyColors = tabbyToggle.colors;
        tabbyColors.normalColor = inState ? buttonColors.selectedColor : buttonColors.normalColor;
        tabbyToggle.colors = tabbyColors;
        Debug.Log(inState);
        tabbyShortDescription_Toggle.localPosition = new Vector3(0f, 0f, 0f);
        fluffyShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
        tuxedoShortDescription_Toggle.localPosition = new Vector3(2000f, 0f, 0f);
    }
}
