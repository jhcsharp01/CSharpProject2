using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public float speed = 0.02f;
    // Update is called once per frame
    void Update()
    {
        float offSetX = speed * Time.deltaTime;
        transform.GetComponent<Renderer>().material.mainTextureOffset += new Vector2(offSetX,0);
        //�������� ���� ��Ƽ���� �����ϰ�
        //��Ƽ������ �ؽ��� �������� �����ϴ� �ڵ�
    }
}
