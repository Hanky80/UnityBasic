using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

	private void Start()//Start() �Լ��� ��ü�� �����ǰ� 1ȸ�� ȣ���
	{					
		//GetComponent<Renderer>().material.color 
		//	= new Color(Random.value, Random.value, Random.value);
	}

	//��ü�� �ٽ� Ȱ��ȭ �ɶ����� �ٽ� ����ǰ� �ϱ����ؼ��� OnEnable() �Լ��� ������.
	//������Ʈ Ǯ���� ���� ��ü�� �ٽ� �������� �ʰ� ���� �Ҷ�, �ʱ�ȭ�� �������ֱ� ����
	//OnEnable() �޽��� �Լ��� �̿��Ѵ�.
	private void OnEnable()
	{
		GetComponent<Renderer>().material.color
			= new Color(Random.value, Random.value, Random.value);
	}

	//��ü�� ��Ȱ��ȭ �ɶ� ȣ��ȴ�. 
	//�ʱ�ȭ ���� �����͸� �����Ҷ� ���.
	private void OnDisable()
	{
		transform.localPosition = Vector3.zero;
	}

	public void OnClick()
	{
		//Ŭ�� �Ǿ����� ������Ʈ �����
		ObjectPoolManager.Instance.RemoveCube(gameObject);

	}

}
