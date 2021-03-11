using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasUpdate : MonoBehaviour
{
    public FixedJoystick joystick2;
    // Start is called before the first frame update
    void Start()
    {
        PlayerController.instance.joystick = joystick2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
