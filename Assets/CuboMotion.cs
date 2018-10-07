using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//Ir a la derecha
		bool goToRight = Input.GetKey (KeyCode.RightArrow);


		if (goToRight) {

			//Debug.Log (isPressed);
			this.transform.Translate (0.2f, 0.0f, 0.0f);
		}
		//Ir a la izquierda
		bool goToLeft = Input.GetKey (KeyCode.LeftArrow);


		if (goToLeft) {

			//Debug.Log (isPressed);
			this.transform.Translate (-0.2f, 0.0f, 0.0f);
		}
		//Ir arriba
		bool goToUp = Input.GetKey (KeyCode.UpArrow);


		if (goToUp) {

			//Debug.Log (isPressed);
			this.transform.Translate (0.0f, 0.2f, 0.0f);
		}
		//Ir abajo
		bool goToDown = Input.GetKey (KeyCode.DownArrow);


		if (goToDown) {

			//Debug.Log (isPressed);
			this.transform.Translate (0.0f, -0.2f, 0.0f);
		}
	}
}
