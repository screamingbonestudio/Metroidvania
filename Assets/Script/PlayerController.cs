using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody2D theRB;//��RigidBody2D���ã�ʹ���ܹ���������ƶ���theRB����script���ܹ�����RigidBody2D�����ƣ�ͨ��call�������������Unity�е�RigidBody2D

    public float moveSpeed;//ˮƽ�ƶ��ٶ�
    public float jumpForce;//������Ծ�ٶ�

    public Transform groundPoint;
    private bool isOnGround;
    public LayerMask whatIsGround;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, theRB.velocity.y);//Input.GetAxisRaw��ȡ���Horizontal�İ�����a���᷵��������ٶ�1��d���᷵�����ҵ��ٶ�1��Ȼ����Ժ����ٶȼ����ƶ���ң�theRB.velocity.yʹ����������ٶȲ���

        isOnGround = Physics2D.OverlapCircle(groundPoint.position, 0.2f, whatIsGround);

        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            theRB.velocity = new Vector2(theRB.velocity.x, jumpForce);//ͨ���ж������û�а����ո�����������ȥ����ڸ���һ��������ٶ�
        }
    }
}
