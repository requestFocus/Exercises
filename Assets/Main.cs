using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
	public Service Service;

	public delegate void DelegateCallback(int a, int b);
	public DelegateCallback DelegateCallbackIns;

	private void Start ()
	{
		for (int i = 0; i < 2; i++)
		{
			if (i < 1)
				DelegateCallbackIns = Service.CallBack1;
			else
				DelegateCallbackIns = Service.CallBack2;

			CallbackMethod(2, 8, DelegateCallbackIns);
		}
	}

	public void CallbackMethod(int a, int b, DelegateCallback cllbck)
	{
		cllbck(a, b);
	}
}
