using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPoolTest : MonoBehaviour
{
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
			//레이캐스트 해서 큐브의 OnClick을 호출

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			Physics.Raycast(ray, out RaycastHit hit);
			Cube cube = null;
			 /*?. 앞의 구문이 null일 경우 해당 라인의 ?? 뒤의 값을반환*/
			if (hit.collider ?. TryGetComponent(out cube) ?? false)
			{
				cube?.OnClick();
			}
		}
    }
}
