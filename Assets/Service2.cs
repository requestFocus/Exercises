using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Service2 : MonoBehaviour
{
	public Main2 Main2;

	private void Start()
	{
		Main2.DelegateMethod(PublishText);					// najpierw wywołanie metody delegata, która przyjmuje funkcję jako argument
	}

	public void PublishText(string text)					// metoda wywoływana jako argument delegata
	{
		Debug.Log(text);
	}
}