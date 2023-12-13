using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTest : MonoBehaviour
{
	public AudioClip[] fireSounds;
	public AudioClip jumpSound;
	public AudioClip damegedSound;

	AudioSource audioSource;

	public AudioSourceControlTest ascPrefab;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}
    private void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
			int clipNum = Random.Range(0, fireSounds.Length);
			//내가 만든 오브젝트를 생성하면서 플레이
			//var asc = Instantiate(ascPrefab);
			//asc.AudioPlay(fireSounds[clipNum]);

			//AudioSource가 제공하는 AudioSource 객체 생성 메소드 호출.
			audioSource.PlayOneShot(fireSounds[clipNum]);
		}
    }
}
