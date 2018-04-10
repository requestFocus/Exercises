using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : MonoBehaviour
{
	public bool State;

	public delegate bool DelegateType();
	public DelegateType DelegateIns;

	private void Start()
	{
		DelegateIns = Method1;

		CallbackMethod(DelegateIns);
	}

	public bool Method1()
	{
		return State;
	}

	public void CallbackMethod(DelegateType cllbck)
	{
		Debug.Log("state: " + cllbck());
	}


	//==========================

	public void Callback1(int a, int b)
	{
		Debug.Log(a + " + " + b + " = " + (a + b));
	}

	public void Callback2(int a, int b)
	{
		Debug.Log(a + " * " + b + " = " + (a * b));
	}
}
