using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeGenerator : MonoBehaviour
{
	private void Start()
	{
		_=StartCoroutine(CubeGenerateCoroutine());
	}

	IEnumerator CubeGenerateCoroutine()
	{
		while (true)
		{
			for (int i = 0; i < 30; i++)
			{
				Vector3 randomPos = Random.insideUnitSphere * 5;

				GameObject cube = ObjectPoolManager.Instance.PopCube();

				cube.transform.position = randomPos;

				yield return new WaitForSeconds(0.1f);
			}

			yield return new WaitForSeconds(10.0f);
		}
	}


}
