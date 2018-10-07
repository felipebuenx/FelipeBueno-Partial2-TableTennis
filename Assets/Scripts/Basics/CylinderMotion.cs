      using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderMotion : MonoBehaviour {

	// Use this for initialization
	void Start () {
        
		
	}
	
	// Update is called once per frame
	void Update () {

        //Esta instruccion mueve el GameObject hacia su derecha
        //this.transform.Translate(Vector3.right);


        if (Input.GetKey(KeyCode.X)) {
            this.transform.Rotate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.Y))
        {
            this.transform.Rotate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Rotate(Vector3.forward);
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.transform.Translate(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);
        }

        //Esta instruccion rota el GameObject con respecto a su eje Y
        //this.transform.Rotate(Vector3.up);
		
	}
}
