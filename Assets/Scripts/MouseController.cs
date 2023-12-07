using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseController : MonoBehaviour
{

	public Color targetColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update() // �� �����Ӹ��� 1ȸ ȣ��
    {


		if (Input.GetButtonDown("Fire1"))//���콺 �Է��� ������ 1ȸ true ��ȯ
		{


			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			Physics.Raycast(ray, out RaycastHit hit);

			if (hit.collider != null)
			{
				hit.collider.GetComponent<Renderer>().material.color = targetColor;
			}
		}
    }
}
