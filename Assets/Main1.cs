using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main1 : MonoBehaviour
{
	public Service1 Service1;

	public delegate void DelegateCallback(int a, int b);
	private DelegateCallback DelegateCallbackIns;

	private void Start()
	{
		for (int i = 0; i < 2; i++)
		{
			if (i < 1)
				DelegateCallbackIns = Service1.Callback1;
			else
				DelegateCallbackIns = Service1.Callback2;

			CallbackMethod(2, 8, DelegateCallbackIns);
		}
	}

	public void CallbackMethod(int a, int b, DelegateCallback cllbck)
	{
		cllbck(a, b);
	}
}
