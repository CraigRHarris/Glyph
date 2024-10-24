using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Combo : MonoBehaviour
{
    public TMP_Text ComboText;
    public int trigger;
    public int combo = 0;

    void Update()
    {
        if (trigger == 1)
        {
            combo += 1;
            ComboText.SetText(combo.ToString());
            trigger = 0;
        }
        if (trigger == 2)
        {
            combo = 0;
            ComboText.SetText(combo.ToString());
            trigger = 0;
        }
    }
}
