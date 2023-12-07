using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rabbit : MonoBehaviour
{
	public Rabbit friendRabbit;

	private void Awake()
	{

		

	}

	void Start()
    {
		if (friendRabbit != null)
		{
			if (friendRabbit.Equals(this))
			{
				print($"{name} 토끼는 나 자신과 친구입니다. 세상은 혼자입니다.");
			}
			else
			{
				print($"{name} 토끼는 {friendRabbit.name} 토끼와 친구입니다.");
			}
		}
		else
		{
			print($"{name} 토끼에게는 친구가 없습니다. 세상은 혼자입니다.");
		}
		
	}



}
