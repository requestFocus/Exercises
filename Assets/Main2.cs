using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main2 : MonoBehaviour
{
	public delegate void DelegateTest(string text);
	private DelegateTest DelegateInsDel;

	private void Start()
	{
		DelegateInsDel("udało się");						// wywołanie delegata
	}
		
	public void DelegateMethod(DelegateTest callback)		// ciało metody, która przypisuje parametr callback do obiektu delegata (tutaj PublishText)
	{
		DelegateInsDel = callback;
	}
}
