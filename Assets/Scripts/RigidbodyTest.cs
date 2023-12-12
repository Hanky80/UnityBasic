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

		//해당 Rigidbody가 보유한 운동량.
		//할당을 통해 값을 덮어쓸 경우, 운동량이 물리작용과 관계없이 완전히 변한다.
		rb.velocity = Vector3.forward;
	}

	bool movePosKey = false;

	//FixedUpdate : 매 프레임마다 1회씩 호출되는 Update와는 별개로
	//유니티에서 물리작용을 연산하는 시점마다 1회씩 호출되는 메시지
	void FixedUpdate()
    {
		//Rigidbody를 통해 물리연산을 함께 계산하며 위치를 이동할때
		//Rigidbody.MovePoition 함수를 이용.
		if(movePosKey) rb.MovePosition(rb.position + (Vector3.down * Time.fixedDeltaTime));
    }

	private void Update()
	{
		float x = Input.GetAxis("Horizontal") * moveSpeed;
		float z = Input.GetAxis("Vertical") * moveSpeed;

		rb.velocity = new Vector3(x, rb.velocity.y, z);

		if (Input.GetKeyDown(KeyCode.Space))
		{
			//Rigidbody.AddForce : Rigidbody에 일정 방향으로 힘을 가한 효과를 준다
			rb.AddForce(Vector3.up * 5 , ForceMode.Impulse);
		}
	}

	private void OnCollisionEnter(Collision collision)//Collision : 충돌 정보
	{
		Debug.Log($"OnCollisonEnter 호출됨 : {collision.collider.name}");
	}
	private void OnCollisionExit(Collision collision)
	{
		Debug.Log($"OnCollisonExit 호출됨 : {collision.collider.name}");
	}
	private void OnCollisionStay(Collision collision)
	{
		Debug.Log($"OnCollisonStay 호출됨 : {collision.collider.name}");
	}

	private void OnTriggerEnter(Collider other) //Collider : 충돌한 객체
	{
		print($"OnTriggerEnter 호출됨 : {other.name}");
	}
	private void OnTriggerExit(Collider other)
	{
		print($"OnTriggerExit 호출됨 : {other.name}");
	}
	private void OnTriggerStay(Collider other)
	{
		print($"OnTriggerStay 호출됨 : {other.name}");
	}

}
