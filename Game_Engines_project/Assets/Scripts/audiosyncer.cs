using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audiosyncer : MonoBehaviour
{
    public float threshold;
    public float interval;
    public float timeToBeat;
    public float resttime;

    private float m_previousAudioValue;
    private float m_audioValue;
    private float m_timer;

    protected bool m_isBeat;
    public virtual void OnBeat()
    {
        Debug.Log("beat");
        m_timer = 0;
        m_isBeat = true;
    }


    public virtual void OnUpdate()
    {
        // update audio value
        m_previousAudioValue = m_audioValue;
        m_audioValue = audiospectrum.spectrumvalue;

        // if audio value went below the threshold during this frame
        if (m_previousAudioValue > threshold &&
            m_audioValue <= threshold)
        {
            // if minimum beat interval is reached
            if (m_timer > interval)
                OnBeat();
        }

        // if audio value went above the bias during this frame
        if (m_previousAudioValue <= threshold &&
            m_audioValue > threshold)
        {
            // if minimum beat interval is reached
            if (m_timer > interval)
                OnBeat();
        }

        m_timer += Time.deltaTime;
    }

    private void Update()
    {
        OnUpdate();
    }

   
}


