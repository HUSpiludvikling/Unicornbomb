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
    private Button button;

    int index = default(int);

    private void Start()
    {
        button = GetComponentInChildren<Button>();
        button.gameObject.SetActive(false);
        text = GetComponentInChildren<Text>();
        image = GetComponentInChildren<Image>();
        SetTextImage(ref index);
        

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SetTextImage(ref index);

            if (story.Linjer_af_tekst.Count <= index && story.Billeder.Count <= index)
            {
                button.gameObject.SetActive(true);
            }
        }
    }

    private void SetTextImage(ref int textlinje)
    {
        try
        {
            text.text = story.Linjer_af_tekst[textlinje];
            image.sprite = story.Billeder[textlinje];
        }
        catch (System.ArgumentOutOfRangeException)
        {

            
        }

        textlinje++;

    }
}

