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

    void Update() // 매 프레임마다 1회 호출
    {


		if (Input.GetButtonDown("Fire1"))//마우스 입력이 있으면 1회 true 반환
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
