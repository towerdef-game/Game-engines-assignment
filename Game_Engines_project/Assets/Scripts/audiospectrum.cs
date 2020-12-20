using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiospectrum : MonoBehaviour
{

    private float[] m_audioSpectrum;
    public static float spectrumvalue { get; private set; }

    void Start()
    {
        m_audioSpectrum = new float[128];
    }

    // Update is called once per frame
  private void Update()
    {
        AudioListener.GetSpectrumData(m_audioSpectrum, 0, FFTWindow.Hamming);

        if(m_audioSpectrum != null && m_audioSpectrum.Length > 0)
        {
            spectrumvalue = m_audioSpectrum[0] * 100;
        }
    }
}
