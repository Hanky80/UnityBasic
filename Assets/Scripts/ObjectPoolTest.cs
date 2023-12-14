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
			//����ĳ��Ʈ �ؼ� ť���� OnClick�� ȣ��

			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			
			Physics.Raycast(ray, out RaycastHit hit);
			Cube cube = null;
			 /*?. ���� ������ null�� ��� �ش� ������ ?? ���� ������ȯ*/
			if (hit.collider ?. TryGetComponent(out cube) ?? false)
			{
				cube?.OnClick();
			}
		}
    }
}
