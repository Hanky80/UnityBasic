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

	//Vector�� �� ���� ���� float�� �ƴ� int�� Ȱ���ϰ� ���� ��
	public Vector2Int vector2Int;
	public Vector3Int vector3Int;



	private void Start()
	{
		//transform.rotation = quaternionVariable;
		//Quaternion�� ������ ������ ���ϱ� ����, x,y,z�� �ܿ� ����� w�� �߰��� ���
		//print(quaternionVariable.x);
		//Quaternion�� x, y, z�� ���� Inspector���� ���� ���� �ٸ���.
	}

	private void Update()
	{
		//Quaternion�� ���� ���� �����ϴ°��� ��Ʊ� ������
		//Transform Ŭ�������� ������ ���� Vector3 ������ �Ҵ��ϱ� ���� �޼ҵ� �� ������Ƽ�� Ȱ����
		//transform.LookAt(lookTarget.position, Vector3.up);

		//Vector3 lookDir = lookTarget.position - transform.position;

		//transform.up = lookDir;		//transform�� up �Ǵ� forward�� ���⺤�͸� �����ϸ�
		//transform.forward = lookDir;	//�ش� ��ü�� y�� �Ǵ� z�� �������� �ٶ�
		//transform.right = -lookDir;

		//�۵����� ����
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
		//�ʸ��� Ư�� ������ ���ݾ� �̵��ϵ��� �غ�����
		//x ������ �̵�

		//Vector3 newPos = transform.position;
		//newPos.y += moveSpeed * Time.deltaTime;
		//transform.position = newPos;

		transform.Translate(moveSpeed * Time.deltaTime, 0, 0, Space.Self); 
		//���� ���� Rotation�� ������� �ʰ� �̵��ϰ� ���� ���, Space.World�� �Ķ���ͷ� �ѱ��.

	}

	private void Rotate()
	{
		transform.Rotate(0, 0, degreePerSecond * Time.deltaTime);
	}

}
