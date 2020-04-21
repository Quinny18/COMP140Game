using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class ArduinoInputs : MonoBehaviour
{
    SerialPort sp = new SerialPort("COM3", 9600);
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        sp.Open();
        sp.ReadTimeout = 1;
    }

    // Update is called once per frame
    void Update()
    {
        speed = float.Parse(sp.ReadLine());
        GameObject.FindObjectOfType<PlayerMovement>().speedInput = speed;
        Debug.Log("speed arduino: " + speed);
    }
}
