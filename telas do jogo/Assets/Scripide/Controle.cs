using System;
using NUnit.Framework.Internal;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Controle : MonoBehaviour
{
    public int volume;
    public int volumeSFX;
    public bool Musica;
    public TMP_Text textomusica;
        
        
    public Slider volumeSlider;
    public Slider volumeSFXSlider;
    public Toggle togglemusica;

    void Start()
    {
        Musica=togglemusica.isOn;
        volume=(int) volumeSlider.value;
        volumeSFX =(int) volumeSFXSlider.value;
    }

     void Update()
    {
        Musica=togglemusica.isOn;
        volume=(int) volumeSlider.value;
        volumeSFX = (int)volumeSFXSlider.value;

        if (Musica == true)
        {
            textomusica.text = "ligado";
            textomusica.color = Color.green;
        }
        else
        {
            textomusica.text = "Desligado";
            textomusica.color = Color.red;
        }
    }
}
