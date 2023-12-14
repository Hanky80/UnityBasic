using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{

	private void Start()//Start() 함수는 객체가 생성되고 1회만 호출됨
	{					
		//GetComponent<Renderer>().material.color 
		//	= new Color(Random.value, Random.value, Random.value);
	}

	//객체가 다시 활성화 될때마다 다시 수행되게 하기위해서는 OnEnable() 함수를 정의함.
	//오브젝트 풀링을 통해 객체를 다시 생성하지 않고 재사용 할때, 초기화를 진행해주기 위해
	//OnEnable() 메시지 함수를 이용한다.
	private void OnEnable()
	{
		GetComponent<Renderer>().material.color
			= new Color(Random.value, Random.value, Random.value);
	}

	//객체가 비활성화 될때 호출된다. 
	//초기화 전에 데이터를 정리할때 사용.
	private void OnDisable()
	{
		transform.localPosition = Vector3.zero;
	}

	public void OnClick()
	{
		//클릭 되었을때 오브젝트 사라짐
		ObjectPoolManager.Instance.RemoveCube(gameObject);

	}

}
