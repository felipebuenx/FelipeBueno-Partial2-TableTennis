using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRacket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float motionSpeed;
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetKey(KeyCode.W)) {
            this.transform.Translate(Vector3.up * motionSpeed);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.transform.Translate(Vector3.down * motionSpeed);
        }

        if (Input.GetKey(KeyCode.A))
        {
            this.transform.Translate(Vector3.right * motionSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
            this.transform.Translate(Vector3.left * motionSpeed);
        }

	}
}
