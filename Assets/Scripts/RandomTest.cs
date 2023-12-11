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
		//Random.Range �Լ� : �Ķ���ͷ� min~max ���� �޾� �� ������ ������ ���� ��ȯ
		print($"Intager Random : {Random.Range(0, 10)}"); // 0~9������ ������ return;
		print($"Float Random : {Random.Range(0f, 10f)}"); // 0~10������ �Ǽ��� return;
		float randomValue = Random.value;//==Random.Range(0f, 1f);
		print($"Random value : {randomValue}");

		//transform.position = Random.insideUnitCircle * 10;
		//Random.insideUnitCirlce : ���� 1�� �� ���� ���� ��ǥ�� Vector2�� ��ȯ

		//transform.position = Random.insideUnitSphere * 10;
		//Random.insideUnitSphere : ���� 1�� ��ü ���� ���� ��ǥ�� Vector3�� ��ȯ

		transform.position = Random.onUnitSphere * 10;
		print(transform.position.magnitude);
		//Random.onUnitSphere : ���� 1�� ��ü�� ���鿡 ��ġ�� ���� ��ǥ�� Vector3�� ��ȯ

		transform.rotation = Random.rotation;

		Random.InitState(982313);
		//Random Ŭ������ �����ϴ� ������ Ư�� �õ尪�� �ð��� �Բ� ������ ������ �����Ѵ�.
		//InitState �Լ� ȣ���� ���� ������ ������ �õ尪�� �ٲ� �� �ִ�.

		thisRenderer = GetComponent<Renderer>();

		StartCoroutine(RandomColorCoroutine());
	}

	IEnumerator RandomColorCoroutine()
	{
		while (true)
		{
			//Random.ColorHSV�� Hue����, Saturationä��, Value���� ������ ������ �������� ���� ����.
			thisRenderer.material.color = new Color(Random.value, Random.value, Random.value);

			//���� �ð����� ������ �ٲ�鼭 Capsule�� �ٸ� �������� �̵��ϵ��� �غ�����.
			//moveDirection�� ���� �������� ����
			yield return new WaitForSeconds(1f);
		}
	}

	Vector3 moveDirecion;

	private void Update()
	{
		//moveDirection���� �̵�
	}

}
