using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Læser story og reflekterer det i tekst og billede
/// </summary>
public class Story_reader : MonoBehaviour
{   //reference til en story//
    public Story story;
    private Text text;
    private Image image;

    int index = default(int);

    private void Start()
    {
        text = GetComponentInChildren<Text>();
        image = GetComponentInChildren<Image>();
        SetTextImage();
        

    }

    private void SetTextImage()
    {
        text.text = story.Linjer_af_tekst[0];
        image.sprite = story.Billeder[0];
    }
}

