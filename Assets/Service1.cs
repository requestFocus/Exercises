using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service1 : MonoBehaviour
{
	public void Callback1(int a, int b)
	{
		Debug.Log(a + " + " + b + " = " + (a + b));
	}

	public void Callback2(int a, int b)
	{
		Debug.Log(a + " * " + b + " = " + (a * b));
	}
}
