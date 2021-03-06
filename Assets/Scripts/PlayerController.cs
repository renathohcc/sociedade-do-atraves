using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    public FixedJoystick joystick;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Movimentacao do player Setas
        //theRB.velocity = new Vector2 (Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"))* moveSpeed;

        // Movimentacao do player Joystick Mobile
        theRB.velocity = new Vector2 (joystick.Horizontal, joystick.Vertical)* moveSpeed;
    }
}
