using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2D : MonoBehaviour
{
    public float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

     transform.position =transform.position + new Vector3(horizontal,vertical,0) * velocidad *Time.deltaTime;
Debug.Log(Time.deltaTime);
    }
}
