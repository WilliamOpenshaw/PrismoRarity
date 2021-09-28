
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class RandomPlayer : MonoBehaviour
{
    public AudioClip[] Clips;
    public float PitchMin = 0.5f;
    public float PitchMax = 1.5f;
    
    public AudioSource source => m_Source;

    AudioSource m_Source;

    void Start()
    {
       // m_Source = GetComponent<AudioSource>();
        m_Source = gameObject.GetComponent<AudioSource>();
        m_Source.volume = 0.01f;
        m_Source.spatialBlend = 1.0f;
        m_Source.minDistance = 1.0f;
        m_Source.maxDistance = 40.0f;
        m_Source.rolloffMode = AudioRolloffMode.Linear;
    }
    public AudioClip GetRandomClip()
    {
        return Clips[Random.Range(0, Clips.Length)];
    }

    public void PlayRandom()
    {
        if(Clips.Length == 0)
            return;
        
        PlayClip(GetRandomClip(), PitchMin, PitchMax);
    }

    public void PlayClip(AudioClip clip, float pitchMin, float pitchMax)
    {
        m_Source.pitch = Random.Range(pitchMin, pitchMax);
        m_Source.volume = 0.01f;
        m_Source.PlayOneShot(clip);
    }
}
