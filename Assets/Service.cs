using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service : MonoBehaviour
{
	public void CallBack1(int a, int b)
	{
		Debug.Log(a + " + " + b + " = " + (a + b));
	}

	public void CallBack2(int a, int b)
	{
		Debug.Log(a + " * " + b + " = " + (a * b));
	}
}
