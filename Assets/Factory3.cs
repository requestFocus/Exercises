using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory3
{
	public Service3 Service3()					// tworzenie instancji Service3
	{
		return new Service3();
	}
}
