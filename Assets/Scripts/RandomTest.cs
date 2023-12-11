using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class RandomTest : MonoBehaviour
{
	Renderer thisRenderer;
    void Start()
    {
		//Random.Range 함수 : 파라미터로 min~max 값을 받아 그 사이의 무작위 수를 반환
		print($"Intager Random : {Random.Range(0, 10)}"); // 0~9까지의 정수를 return;
		print($"Float Random : {Random.Range(0f, 10f)}"); // 0~10까지의 실수를 return;
		float randomValue = Random.value;//==Random.Range(0f, 1f);
		print($"Random value : {randomValue}");

		//transform.position = Random.insideUnitCircle * 10;
		//Random.insideUnitCirlce : 길이 1의 원 안의 랜덤 좌표를 Vector2로 반환

		//transform.position = Random.insideUnitSphere * 10;
		//Random.insideUnitSphere : 길이 1의 구체 안의 랜덤 좌표를 Vector3로 반환

		transform.position = Random.onUnitSphere * 10;
		print(transform.position.magnitude);
		//Random.onUnitSphere : 길이 1의 구체의 경계면에 위치한 랜덤 좌표를 Vector3로 반환

		transform.rotation = Random.rotation;

		Random.InitState(982313);
		//Random 클래스가 생성하는 난수는 특정 시드값에 시간을 함께 연산한 값으로 생성한다.
		//InitState 함수 호출을 통해 난수를 생성할 시드값을 바꿀 수 있다.

		thisRenderer = GetComponent<Renderer>();

		StartCoroutine(RandomColorCoroutine());
	}

	IEnumerator RandomColorCoroutine()
	{
		while (true)
		{
			//Random.ColorHSV는 Hue색조, Saturation채도, Value명도로 구성된 복잡한 기준으로 색을 결정.
			thisRenderer.material.color = new Color(Random.value, Random.value, Random.value);

			//일정 시간마다 색깔이 바뀌면서 Capsule이 다른 방향으로 이동하도록 해보세요.
			//moveDirection의 값을 랜덤으로 생성
			yield return new WaitForSeconds(1f);
		}
	}

	Vector3 moveDirecion;

	private void Update()
	{
		//moveDirection으로 이동
	}

}
