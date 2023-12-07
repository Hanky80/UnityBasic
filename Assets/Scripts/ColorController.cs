using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class ColorController : MonoBehaviour
{
	public Color targetColor;

	private MeshRenderer targetRenderer;

	private void Awake()
	{
		targetRenderer = GetComponent<MeshRenderer>();
	}

	private void Start()
	{
		targetRenderer.material.color = targetColor;
	}

	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.K))
		{
			//
		}
	}

}
