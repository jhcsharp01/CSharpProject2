using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

//�ش� ��ũ��Ʈ�� ������Ʈ�� ����� ��� �ݵ�� Rigidbody2D�� �����ؾ� �մϴ�.
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerController : MonoBehaviour
{
    //�÷��̾� �̵� ��� ����(use Rigidbody2D)
    //����Ƽ������ �پ��� �̵� ��� ������ ���� �����Ͱ� �����ϴµ� ���߿���
    //������ٵ� �̿��� ���� ���� ��� ���� �̵��� ������ ���Դϴ�.

    public int speed; //�̵� �ӵ�
    public int max_speed; //�ִ� �̵��ӵ�

    Rigidbody2D rigidbody2D;//������ٵ� ������Ʈ

    private void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        //GetComponent<T>�� �ش� T ������ ������Ʈ�� ������ ����� ������ �ֽ��ϴ�.
        //���� PlayerController�� ������Ʈ�� ���� �ִ� Circle�� Rigidbody2D ������Ʈ�� ������ ����ϴ� ����
    }

    //Main Logic
    void Update()
    {
        Move();
        Jump();
    }


    public float jump;
    void Jump()
    {
        //���� ��ư�� ������ �� ������ ����ǵ��� ����
        //Jump�� InputManager���� Space Ű�� �۵��մϴ�.
        if(Input.GetButtonDown("Jump"))
        {
            rigidbody2D.AddForce(Vector2.up * jump, ForceMode2D.Impulse); 
        }
    }


    void Move()
    {
        float h = Input.GetAxisRaw("Horizontal");
        //����Ƽ���� Input Manager�� �����մϴ�.
        //����Ƽ���� ����ϴ� �Է¿� ���õ� �������� ����Ǿ��ֽ��ϴ�.
        //���߿��� Axies�� �ҷ����� ������ GetAxis
        //�� ����� -1, 0 , 1�� �������� ������ GetAxisRaw�� �ַ� 1ĭ �̵��� ���� ���� �� ����մϴ�.
        //Horiziontal axies �߿��� ���ο� ���� �Է��Դϴ�.

        rigidbody2D.AddForce(Vector2.right * h * speed, ForceMode2D.Impulse);
        //AddForce�� ����� �� ��带 ���� ���� ���ϴ� ����
        //����Ƽ���� ������ Vector2�� ���� 2d�� x��� y���� ��ǥ�� ǥ���մϴ�.
        //                Vector3�� ���� 3d�� x,y,z���� ��ǥ�� ǥ���մϴ�.
        //�� ���� ��ü�� ���� ���ϴ� �Ϳ� ���� ����
        //2D ���� Impulse , Force�� ������ �������� ���̳� �������� ���̳ķ� �����ϴ�.

        //��ü�� x ��ǥ �ӷ��� �����ص� �ִ� ���ǵ庸�� �����ٸ�
        if (rigidbody2D.velocity.x > max_speed)
        {
            //������ �̵� ����
            rigidbody2D.velocity = new Vector2(max_speed, rigidbody2D.velocity.y);
            //�ӷ��� �ִ� �ӵ��� �����մϴ�.
        }
        else if (rigidbody2D.velocity.x < -1 * max_speed)
        {
            //���� �̵� ����
            rigidbody2D.velocity = new Vector2(-1 * max_speed, rigidbody2D.velocity.y);
        }
    }


}
