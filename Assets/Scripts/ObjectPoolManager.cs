using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public enum PoolType
{
	mouse,
	ghost,
	bullet,
}


public class ObjectPoolManager : MonoBehaviour
{
	
	//�̱��� ����
	public static ObjectPoolManager Instance
	{
		get //2��������, ���ӿ� �� ObjectPoolManager�� �����ؾ� �ϴ°��
		{
			if (instance == null)
			{
				instance = new GameObject("ObjectPoolManager").AddComponent<ObjectPoolManager>();
			}
			return instance;
		}
	} //�ܺ� ��ü������ ������ ������ ������Ƽ
	 
	public static ObjectPoolManager instance;

	public GameObject cubePrefab;

	//���Ӿ��� �ö�� ������Ʈ�� ����� ���� �� ���� �ϴ°��� ���ҽ��� ��ȿ�����̴�.
	//���Ӿ��� �ö�� ������Ʈ�� ���� �ϱ� ���ؼ� ������Ʈ Ǯ�� ����Ѵ�.

	public List<GameObject> activatedCubes = new List<GameObject>();

	public List<GameObject> inactivatedCubes = new List<GameObject>();

	public int initCubeCount;

	private Dictionary<PoolType, List<GameObject>> objectDic = new Dictionary<PoolType, List<GameObject>>();

	private void Awake()
	{
		//1���� Instance ������Ƽ�� null ���θ� Ȯ��
		if (instance != null)
		{
			DestroyImmediate(this);
			return;
		} 
		instance = this;
	}
	//����Ƽ���� �̱������� ��;

	void Start()
	{
		for (int i = 0; i < initCubeCount; i++)
		{
			GameObject cube = Instantiate(cubePrefab);
			cube.transform.parent = transform;
			cube.SetActive(false);
			inactivatedCubes.Add(cube);
		}
		
	}

	public void RemoveCube(GameObject cube)
	{
		if (inactivatedCubes.Count > 30)
		{
			Destroy(cube);
		}
		else if (activatedCubes.Remove(cube))
		{
			cube.transform.parent = transform;
			cube.SetActive(false);
			inactivatedCubes.Add(cube);
		}
	}

	public GameObject PopCube() 
	{   // ť�긦 ���� �ϱ� ���� inactivatedCubes list���� �ϳ��� ������.
		// ť�갡 ���� �� ���� �����Ͽ� ��ȯ��.
		if (inactivatedCubes.Count > 0)
		{
			GameObject cube = inactivatedCubes[0];
			if (inactivatedCubes.Remove(cube))
			{
				activatedCubes.Add(cube);
			}
			cube.transform.parent = null;
			cube.SetActive(true);
			return cube;
		}
		else
		{
			GameObject cube = Instantiate(cubePrefab);

			activatedCubes.Add(cube);

			return cube;
		}
	}

}
