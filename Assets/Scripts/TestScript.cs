using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Object = UnityEngine.Object;

public class TestScript : MonoBehaviour
{
	//TestScript��� Ŭ������ �ʵ�(����)�� ������ �ִ�.
	public int HP = 10; //������(intager) ����
	public float MP; //�Ǽ���(float) ����

	[Header("��� �׽�Ʈ")]
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

	//���������ڰ� private�� ������ Inpector���� ���� �Ұ�.
	[SerializeField]//SerializeField ��Ʈ����Ʈ�� ���� Inpector���� ������ ����.
	private int privateIntager = 10;

	[HideInInspector]//SerializeField�� �ݴ��, ��ũ��Ʈ�� ������ �� ������ 
					 //Inspector���� ���� �Ұ�.
	public int publicIntager = 20;


	//Scene �Ǵ� ���������� ������ GameObject�� ������ �� ����
	public GameObject otherObject;

	[Tooltip("Ʈ������ ������Ʈ �Ҵ� ����")]
	public Transform boxTransform;
	public MeshFilter boxMeshFilter;
	public MeshRenderer boxMeshRenderer;
	public BoxCollider boxCollider;

	public TestScript myTestScript;

	public MyClass myClass = null; //Unity�� ���� �Ҵ� ����

	public Object objectVariable; //����Ƽ ������ ���Ǵ� ��ü�� ��� �Ҵ� ����

	public int[] intArray;// Inpector���� �Ҵ��� ���� �ڵ����� (Unity�� ���ؼ�) �Ҵ��
	public List<int> intList; //LinkedList ... .... ... ...

	public List<GameObject> gameObjectList;

	public void Awake()//���������ڵ� ���� �����ϰ�, ���� ȣ�⵵ ����
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


//���� ���� �ۼ��� Ŭ������ �ܺ� ���α׷��� ����Ƽ���� Ȱ���ϱ� ���ؼ�
//�������� ����ȭ�� �ʿ���.

//C# Attribute
[System.Serializable]
public class MyClass
{
	//����Ƽ���� MyClass�� �����Ͽ� �Ҵ��� ���, ���� ������ ������ ������
	//�ڱ� �ڽ� Ÿ���� ������ Inspector�� ���� ����� �� ����.
	public MyClass myClass; // Inspector���� �� �� ����.
	public int a;
	public float b;
	public string c;
	public GameObject gameObject;
}
