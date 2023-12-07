using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMouse : MonoBehaviour
{

	public List<Cube> cubes;
	public Color clickColor;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
		if (Input.GetButtonDown("Fire1"))
		{
			Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out RaycastHit hit))
			{
				hit.collider.GetComponent<Renderer>().material.color = clickColor;
				Cube cube = hit.collider.GetComponent<Cube>();
				cube.isClicked = true;
				if (cube.isAnswer)
				{
					print("정답");
				}
				else
				{
					print("오답");
				}
			}

			bool isClear = true;

			foreach (Cube cube in cubes)
			{

				if (cube.isAnswer == false && cube.isClicked == true)
				{
					print("틀렸습니다");
					break;
				}

				if (cube.isAnswer == true && cube.isClicked == false)
				{
					isClear = false;
				}

			}

			if (isClear) print("정답입니다.");

		}
    }
}
