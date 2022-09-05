using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Sonido : MonoBehaviour
{
    public AudioSource aud;

    public AudioClip Clip;

    public TextMeshProUGUI LevelValue, PitchValue, PanValue;

    public Slider LevelSlider, PanSlider, PitchSlider;

    public Toggle Loop;

    public TextMeshProUGUI ButtonText;

    bool estado = true;


    // Start is called before the first frame update
    void Start()
    {
        aud.clip = Clip;
    }
    
    public void Reproducir()
    {
        if (estado)
        {
            aud.Play();
            estado = false;
            ButtonText.SetText("Stop");
        }
        else
        {
            aud.Stop();
            estado = true;
            ButtonText.SetText("Play");
        }
    }

    public void ChangeLevel()
    {
        aud.volume = LevelSlider.value;
        LevelValue.SetText(LevelSlider.value.ToString());
    }

    public void ChangePan()
    {
        aud.panStereo = PanSlider.value;
        PanValue.SetText(PanSlider.value.ToString());
    }

    public void ChangePitch()
    {
        aud.pitch = PitchSlider.value;
        PitchValue.SetText(PitchSlider.value.ToString());
    }

    public void ChangeLoop()
    {
        aud.loop = Loop.isOn;
    }
}
