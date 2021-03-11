using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody2D theRB;
    public float moveSpeed;
    public FixedJoystick joystick;
    public Animator myAnim;
    public float hMove = 0f;
    public float vMove = 0f;

    public static PlayerController instance;
    public string areaTransitionName;

    private Vector3 bottomLeftLimit;
    private Vector3 topRightLimit;

    // Start is called before the first frame update
    void Start()
    {
        // Não duplicar o player ao trocar de cenas
       if(instance == null){
            instance = this;
        }
        else{
            Destroy(gameObject);
        }

        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        // Variaveis de Movimentacao
        //hMove = Input.GetAxisRaw("Horizontal");
        //vMove = Input.GetAxisRaw("Vertical");

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
        //Keep the Player in the Map
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, bottomLeftLimit.x, topRightLimit.x), Mathf.Clamp(transform.position.y, bottomLeftLimit.y, topRightLimit.y), transform.position.z);
    }

    public void setBounds(Vector3 botLeft, Vector3 topRight)
    {
        bottomLeftLimit = botLeft + new Vector3(.5f, 1f, 0f);
        topRightLimit = topRight + new Vector3 (-.5f, -1f, 0f);
    }

   

    
}
