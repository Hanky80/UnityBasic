using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceControlTest : MonoBehaviour
{
	AudioSource audioSource;
	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	void Update()
    {
        if(false == audioSource.isPlaying)
		{
			Destroy(gameObject);
		}
    }

	public void AudioPlay(AudioClip clip)
	{
		audioSource.clip = clip;
		audioSource.Play();
	}

}
