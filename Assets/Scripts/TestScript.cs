using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class TestScript : MonoBehaviour
{
	//TestScript라는 클래스도 필드(변수)를 가질수 있다.
	public int HP = 10; //정수형(intager) 변수
	public float MP; //실수형(float) 변수

	[Header("헤더 테스트")]
	public bool boolVariable = true;

	[Space(20)]
	public short shortVariable = short.MinValue;

	public ushort ushortVariable = ushort.MaxValue;

	[Range(1, 20)]
	public int intVariable = int.MaxValue;
	public uint uintVariable = uint.MaxValue;
	public long longVariable = long.MaxValue;
	public ulong ulongVariable = ulong.MaxValue;
	public float floatVariable = float.MaxValue;
	public double doubleVariable = double.MaxValue;
	public decimal decimalVariable = decimal.MaxValue;

	[TextArea(2, 5)]
	public string stringVariable = "string";

	//접근지정자가 private인 변수는 Inpector에서 접근 불가.
	[SerializeField]//SerializeField 어트리뷰트를 통해 Inpector에서 수정이 가능.
	private int privateIntager = 10;

	[HideInInspector]//SerializeField와 반대로, 스크립트로 접근할 수 있지만 
					 //Inspector에서 접근 불가.
	public int publicIntager = 20;


	//Scene 또는 프리팹으로 생성된 GameObject를 참조할 수 있음
	public GameObject otherObject;

	[Tooltip("트랜스폼 컴포넌트 할당 가능")]
	public Transform boxTransform;
	public MeshFilter boxMeshFilter;
	public MeshRenderer boxMeshRenderer;
	public BoxCollider boxCollider;

	public TestScript myTestScript;

	public MyClass myClass = null; //Unity가 값을 할당 해줌

	public Object objectVariable; //유니티 내에서 사용되는 객체는 모두 할당 가능

	public int[] intArray;// Inpector에서 할당한 값이 자동으로 (Unity에 의해서) 할당됨
	public List<int> intList; //LinkedList ... .... ... ...

	public List<GameObject> gameObjectList;

	public void Awake()//접근지정자도 변경 가능하고, 따로 호출도 가능
	{
		Debug.Log("Awake");
	}
	private void Start()
	{
		Awake();

		Debug.Log("Start");
		//print("Start");

		foreach (GameObject gameObject in gameObjectList) {

			print(gameObject.name);

		}

	}

}


//내가 직접 작성한 클래스는 외부 프로그램인 유니티에서 활용하기 위해서
//데이터의 직렬화가 필요함.

//C# Attribute
[System.Serializable]
public class MyClass
{
	//유니티에서 MyClass를 생성하여 할당할 경우, 무한 루프에 빠지기 때문에
	//자기 자신 타입의 변수는 Inspector를 통해 취급할 수 없다.
	public MyClass myClass; // Inspector에서 볼 수 없음.
	public int a;
	public float b;
	public string c;
	public GameObject gameObject;
}
