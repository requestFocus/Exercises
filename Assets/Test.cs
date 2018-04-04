using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {

	void Start () {
		Debug.Log("test");		
		Debug.Log("2 kwietnia, commit z domu");		
		Debug.Log("3 kwietnia, commit z roboty");		
		Debug.Log("3 kwietnia, commit z domu + PUSH");		
		Debug.Log("3 kwietnia, commit z domu, bez PUSH");		
		Debug.Log("4 kwietnia, commit z domu + PUSH // w międzyczasie z pracy był PUSH");		
		Debug.Log("4 kwietnia, commit z roboty + PUSH");		
	}
}


/*
 * [linijka ===== oddziela wykonane od niewykonanych]
 * 
 * najpierw stworzyłem repo
 * potem stworzyłem w nim projekt unity
 * stworzyłem skrypt, gameobject itd., zrobiłem commit, publish repo
 * pojawiło się na github.com
 * dodałem drugą linijkę debug.log i ten opis
 * W ROBOCIE po zrobieniu clone'a dodać kolejną linijkę debug.log i zacommitować + PUSH
 * W DOMU zrobić pull (fetch + merge)
 * następnie dodać linijkę i zacommitować + PUSH 
 * następnie dodać linijkę i zacommitować, BEZ PUSH (obie wersje mają się od tej pory różnić)
 * W ROBOCIE dodać linijkę i zacommitować + PUSH (nie powinno być konfliktu, w remocie będzie wersja bez dodatkowych zmian Z DOMU)
 * W DOMU dodać linijkę i zacommitować + PUSH (powinien pojawić się konflikt, bo wersje będą się różnić) - pojawił się konflikt, patrz niżej
 * ======================================================================================================
 * w ROBOCIE dodać linijkę i zacommitować, następnie spróbować zrobić PUSH, powinien zaproponować PULL, a następnie pokazać konflikt (najprawdopodobniej tym razem HEAD będzie dotyczył brancha pracowego, a zmiany domowe remote'a)
 * 
 * <<<<<<< HEAD															// <<<< HEAD - current branch, czyli ten branch, na którym aktualnie pracuję, 
		Debug.Log("3 kwietnia, commit z domu, bez PUSH");		
		Debug.Log("4 kwietnia, commit z domu + PUSH // w międzyczasie z pracy był PUSH");		
=======																	// ==== oddziela zmiany na HEADzie i remote'ie
		Debug.Log("4 kwietnia, commit z roboty + PUSH");				// >>>> zmiany wprowadzone na remote'ie, których nie ma na current branchu, a które wyszły dopiero po próbie PUSH/PULLA
>>>>>>> 10bf02c8b0571a2bdba582b680a18e9605694ec7
 *
 * 
 * 
 * 
 * 
 * 
 * na jakimś etapie pojawi się tu factory: klasa A będzie mieć dostęp do klasy B bez tworzenia instancji klasy B w sobie, póki co zabawa w zmiany
 */
