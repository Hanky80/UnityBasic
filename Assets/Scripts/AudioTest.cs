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
			//���� ���� ������Ʈ�� �����ϸ鼭 �÷���
			//var asc = Instantiate(ascPrefab);
			//asc.AudioPlay(fireSounds[clipNum]);

			//AudioSource�� �����ϴ� AudioSource ��ü ���� �޼ҵ� ȣ��.
			audioSource.PlayOneShot(fireSounds[clipNum]);
		}
    }
}
