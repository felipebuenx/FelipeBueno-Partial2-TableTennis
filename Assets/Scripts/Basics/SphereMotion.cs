using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMotion : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // Asi movemos un objeto
        this.transform.Translate(Vector3.left);
    }


    // Update is called once per frame
    void Update()
    {

        // Si presiono la tecla flecha iquierda, muevo el cilindro hacia la izq.
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left);

        }

        // Si presiono la tecla flecha derecha, muevo el cilindro hacia la der.
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right);

        }

        // Si presiono la tecla flecha derecha, muevo el cilindro hacia la der.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.up);

        }

        // Si presiono la tecla flecha derecha, muevo el cilindro hacia la der.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.down);

        }

        // Si presiono la tecla Y, roto el cilindro con respecto al eje Y.
        if (Input.GetKey(KeyCode.Y))
        {
            this.transform.Rotate(Vector3.up);

        }

        // Si presiono la tecla X, roto el cilindro con respecto al eje X.
        if (Input.GetKey(KeyCode.X))
        {
            this.transform.Rotate(Vector3.right);

        }

        // Si presiono la tecla Z, roto el cilindro con respecto al eje Z.
        if (Input.GetKey(KeyCode.Z))
        {
            this.transform.Rotate(Vector3.forward);

        }



    }
}