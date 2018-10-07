using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightRacket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    public float motionSpeed;
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.right * motionSpeed);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.left * motionSpeed);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up * motionSpeed);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down * motionSpeed);
        }
		
	}
}
