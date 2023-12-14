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
	
	//싱글톤 패턴
	public static ObjectPoolManager Instance
	{
		get //2차적으로, 게임에 꼭 ObjectPoolManager가 존재해야 하는경우
		{
			if (instance == null)
			{
				instance = new GameObject("ObjectPoolManager").AddComponent<ObjectPoolManager>();
			}
			return instance;
		}
	} //외부 객체에서는 참조만 가능한 프로퍼티
	 
	public static ObjectPoolManager instance;

	public GameObject cubePrefab;

	//게임씬에 올라온 오브젝트를 빈번히 생성 후 삭제 하는것은 리소스가 비효율적이다.
	//게임씬에 올라온 오브젝트를 재사용 하기 위해서 오브젝트 풀을 사용한다.

	public List<GameObject> activatedCubes = new List<GameObject>();

	public List<GameObject> inactivatedCubes = new List<GameObject>();

	public int initCubeCount;

	private Dictionary<PoolType, List<GameObject>> objectDic = new Dictionary<PoolType, List<GameObject>>();

	private void Awake()
	{
		//1차로 Instance 프로퍼티의 null 여부만 확인
		if (instance != null)
		{
			DestroyImmediate(this);
			return;
		} 
		instance = this;
	}
	//유니티에서 싱글톤패턴 끝;

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
	{   // 큐브를 재사용 하기 위해 inactivatedCubes list에서 하나를 꺼내옴.
		// 큐브가 없을 시 새로 생성하여 반환함.
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
