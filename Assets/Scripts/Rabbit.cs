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
				print($"{name} �䳢�� �� �ڽŰ� ģ���Դϴ�. ������ ȥ���Դϴ�.");
			}
			else
			{
				print($"{name} �䳢�� {friendRabbit.name} �䳢�� ģ���Դϴ�.");
			}
		}
		else
		{
			print($"{name} �䳢���Դ� ģ���� �����ϴ�. ������ ȥ���Դϴ�.");
		}
		
	}



}
