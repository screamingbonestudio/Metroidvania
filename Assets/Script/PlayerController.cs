using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D theRB;//将RigidBody2D调用，使其能够控制玩家移动。theRB是在script中能够调用RigidBody2D的名称，通过call这个名称来调用Unity中的RigidBody2D

    public float moveSpeed;//水平移动速度
    public float jumpForce;//纵向跳跃速度

    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);//Input.GetAxisRaw读取玩家Horizontal的按键，a键会返还向左的速度1，d键会返还向右的速度1，然后乘以横向速度即可移动玩家，theRB.velocity.y使得玩家纵向速度不变

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, 0.2f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);//通关判断玩家有没有按键空格键，如果按下去则会在给予一个纵向的速度
        }
    }
}
