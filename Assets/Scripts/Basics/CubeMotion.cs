using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMotion : MonoBehaviour {


	// Update is called once per frame
	void Update () {
		
		// Mueve el game object a la derecha
		this.transform.Translate (1, 0, 0); 

		//Muestra la posicion del game object
		//Debug.Log (this.transform.position);
	}
}
