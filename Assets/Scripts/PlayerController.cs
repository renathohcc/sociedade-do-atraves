using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    public FixedJoystick joystick;
    public Animator myAnim;
    private float hMove;
    private float vMove;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Variaveis de Movimentacao
        //h = Input.GetAxisRaw("Horizontal");
        //v = Input.GetAxisRaw("Vertical");

        hMove = joystick.Horizontal;
        vMove = joystick.Vertical;

        // Movimentacao do player
        theRB.velocity = new Vector2 (hMove, vMove)* moveSpeed;

        // Animacao do Player
        myAnim.SetFloat("moveX", theRB.velocity.x);
        myAnim.SetFloat("moveY", theRB.velocity.y);

        if(hMove == 1 || hMove == -1 || vMove == 1 || vMove == -1)
        {
            myAnim.SetFloat("lastMoveX", hMove);
            myAnim.SetFloat("lastMoveY", vMove);
        }
    }
}
