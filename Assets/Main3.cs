using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main3 : MonoBehaviour
{
	private Factory3 factory3;
	private IService3 service3If;

	private void Start ()
	{
		factory3 = new Factory3();                  // to wywołanie tworzy instancję Service3 i innych klas, których wywołania zawiera factory
		service3If = factory3.Service3();

		Debug.Log("Name is: " + service3If.Name);
	}
}
