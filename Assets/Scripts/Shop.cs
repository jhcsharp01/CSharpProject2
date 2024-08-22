using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//상점 설계
//플레이어가 NPC와 충돌했을 경우 열리게 설계

public class Shop : MonoBehaviour
{
    public GameObject shop;
    public bool isOn = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(isOn == false)
        {
            shop.SetActive(true);
            isOn = true;
        }
        else
        {
            shop.SetActive(false);
            isOn = false;
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    isOn = false;
    //}
}
