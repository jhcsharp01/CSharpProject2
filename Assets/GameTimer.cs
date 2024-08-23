using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//0���� ���� �þ�� Ÿ�̸�
public class GameTimer : MonoBehaviour
{
    public Text timer_text;

    private float time;
    private float time_limit = 10.0f; //Ÿ�� ����Ʈ�� 60��

    private void Awake()
    {
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //���ѽð����� ���� �ð��̶��, �۾� ����
        if (time <= time_limit)
        {
            time += Time.deltaTime; //������ �� �ð���ŭ �����մϴ�.(�� 1��)

            timer_text.text = Mathf.Ceil(time).ToString();
            //�Ҽ��� ���� �Լ�
            //Mathf.Round() �ݿø�
            //Mathf.Ceil()  �ø�
            //Mathf.Floor() ����
        }
        else
        {
            Time.timeScale = 0;
            //Ÿ�� �������� �ð��� �帣�� �Ϳ� ���� ǥ��
            //�⺻������ 1�� ���� ������ �ְ�
            //��ġ�� �������� �׸�ŭ �ð��� ������ �귯��.
        }

    }
}
