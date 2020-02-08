﻿
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{

    private Image image;

    private void Awake() 
    {
        image = transform.GetComponent<Image>();
    }

    private void Update() 
    {
         image.fillAmount = Loader.GetLoadingProgress();
    }
}
