﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightningManager : MonoBehaviour
{

    public float offmin = 10f;
    public float offMax = 60f;
    public float onMin = 0.25f;
    public float onMax = 0.8f;
    public Light light;
    public AudioClip[] thunderSounds;
    public AudioSource audioSource;

    void Start()
    {
        StartCoroutine("LightningFX");
    }

    IEnumerator LightningFX()
    {
        while (true)
        {
            yield return new WaitForSeconds(Random.Range(offmin, offMax));
            light.enabled = true;

            StartCoroutine("SoundFX");

            yield return new WaitForSeconds(Random.Range(onMin, onMax));
            light.enabled = false;
        }
    }

    IEnumerator SoundFX()
    {
        yield return new WaitForSeconds(Random.Range(.25f, 1.75f));
        audioSource.PlayOneShot(thunderSounds[Random.Range(0, thunderSounds.Length)]);
    }
}