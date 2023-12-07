using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
	public bool isAnswer;

	public bool isClicked;

	public Color answerColor;

	private void Start()
	{
		if (isAnswer)
		{
			GetComponent<Renderer>().material.color = answerColor;
		}
	}

}
