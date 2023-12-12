using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidbodyTest : MonoBehaviour
{
	Rigidbody rb;
	public float moveSpeed;
	private void Start()
	{
		rb = GetComponent<Rigidbody>();

		//�ش� Rigidbody�� ������ ���.
		//�Ҵ��� ���� ���� ��� ���, ����� �����ۿ�� ������� ������ ���Ѵ�.
		rb.velocity = Vector3.forward;
	}

	bool movePosKey = false;

	//FixedUpdate : �� �����Ӹ��� 1ȸ�� ȣ��Ǵ� Update�ʹ� ������
	//����Ƽ���� �����ۿ��� �����ϴ� �������� 1ȸ�� ȣ��Ǵ� �޽���
	void FixedUpdate()
    {
		//Rigidbody�� ���� ���������� �Բ� ����ϸ� ��ġ�� �̵��Ҷ�
		//Rigidbody.MovePoition �Լ��� �̿�.
		if(movePosKey) rb.MovePosition(rb.position + (Vector3.down * Time.fixedDeltaTime));
    }

	private void Update()
	{
		float x = Input.GetAxis("Horizontal") * moveSpeed;
		float z = Input.GetAxis("Vertical") * moveSpeed;

		rb.velocity = new Vector3(x, rb.velocity.y, z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//Rigidbody.AddForce : Rigidbody�� ���� �������� ���� ���� ȿ���� �ش�
			rb.AddForce(Vector3.up * 5 , ForceMode.Impulse);
		}
	}

	private void OnCollisionEnter(Collision collision)//Collision : �浹 ����
	{
		Debug.Log($"OnCollisonEnter ȣ��� : {collision.collider.name}");
	}
	private void OnCollisionExit(Collision collision)
	{
		Debug.Log($"OnCollisonExit ȣ��� : {collision.collider.name}");
	}
	private void OnCollisionStay(Collision collision)
	{
		Debug.Log($"OnCollisonStay ȣ��� : {collision.collider.name}");
	}

	private void OnTriggerEnter(Collider other) //Collider : �浹�� ��ü
	{
		print($"OnTriggerEnter ȣ��� : {other.name}");
	}
	private void OnTriggerExit(Collider other)
	{
		print($"OnTriggerExit ȣ��� : {other.name}");
	}
	private void OnTriggerStay(Collider other)
	{
		print($"OnTriggerStay ȣ��� : {other.name}");
	}

}
