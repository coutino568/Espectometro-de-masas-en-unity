using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public bool sentidoHorario;
    Vector3 initialPosition;

    public GameObject c;
    void Start()
    {
        if (sentidoHorario)
        {
            initialPosition = new Vector3(0.0f, -90, 0.0f);
            
        } else
        {
            initialPosition = new Vector3(0, -90, 180);

        }
        transform.rotation = Quaternion.Euler(initialPosition);

    }

    void Update()
    {
        if (Time.timeScale == 1f) {
            transform.Rotate(Vector3.right);
        }
        

        if (sentidoHorario && c.transform.rotation.eulerAngles.x > 178)
        {
            transform.rotation = Quaternion.Euler(initialPosition);
        }
        if ((sentidoHorario==false) && c.transform.rotation.eulerAngles.x < 178)
        {
            transform.rotation = Quaternion.Euler(initialPosition);
        }


    }
}
