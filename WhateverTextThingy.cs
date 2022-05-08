using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhateverTextThingy : MonoBehaviour //Add reference to UI Text here via the inspector
{
    public float timeValue = 30;
    public Canvas tryAgainCanvas;

    void Update()
    {
        if (timeValue > 0)
        {
            timeValue -= Time.deltaTime;
        }
        else
        {
            timeValue = 0;
            showTip();
        }
    }

    void showTip()
    {
        tryAgainCanvas.gameObject.SetActive(true);
        //Debug.Log("end scene");
        return;
    }
}