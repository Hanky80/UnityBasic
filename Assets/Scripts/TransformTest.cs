using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TransformTest : MonoBehaviour
{
	public Transform lookTarget;

	public Vector2 vector2Variable;
	public Vector3 vector3Variable;
	public Vector4 vector4Variable;
	public Quaternion quaternionVariable;

	private float zDegree = 0;
	public float degreePerSecond;

	public float moveSpeed;

	//Vector의 각 축의 값을 float이 아닌 int로 활용하고 싶을 때
	public Vector2Int vector2Int;
	public Vector3Int vector3Int;



	private void Start()
	{
		//transform.rotation = quaternionVariable;
		//Quaternion은 짐벌락 현상을 피하기 위해, x,y,z축 외에 허수부 w를 추가로 사용
		//print(quaternionVariable.x);
		//Quaternion의 x, y, z축 값은 Inspector에서 보는 값과 다르다.
	}

	private void Update()
	{
		//Quaternion의 값을 직접 제어하는것이 어렵기 때문에
		//Transform 클래스에서 방향을 직접 Vector3 값으로 할당하기 위한 메소드 및 프로퍼티를 활용함
		//transform.LookAt(lookTarget.position, Vector3.up);

		//Vector3 lookDir = lookTarget.position - transform.position;

		//transform.up = lookDir;		//transform의 up 또는 forward에 방향벡터를 대입하면
		//transform.forward = lookDir;	//해당 객체의 y축 또는 z축 방향으로 바라봄
		//transform.right = -lookDir;

		//작동하지 않음
		//zDegree = transform.rotation.z;
		//zDegree += degreePerSecond;
		//Quaternion newDegree = new Quaternion(0,0,zDegree,0);
		//transform.rotation = newDegree;


		//zDegree = transform.rotation.eulerAngles.z;
		//zDegree += degreePerSecond * Time.deltaTime;
		//Vector3 newEulerAngle = new Vector3(0, 0, zDegree);
		//transform.rotation = Quaternion.Euler(newEulerAngle);

		//transform.Rotate(0, 0, degreePerSecond * Time.deltaTime);

		Move();
		Rotate();
	}

	private void Move()
	{
		//초마다 특정 축으로 조금씩 이동하도록 해보세요
		//x 축으로 이동

		//Vector3 newPos = transform.position;
		//newPos.y += moveSpeed * Time.deltaTime;
		//transform.position = newPos;

		transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.Self); 
		//현재 나의 Rotation을 고려하지 않고 이동하고 싶을 경우, Space.World를 파라미터로 넘긴다.

	}

	private void Rotate()
	{
		transform.Rotate(0, 0, degreePerSecond * Time.deltaTime);
	}

}
