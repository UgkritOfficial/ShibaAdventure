using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInfo : MonoBehaviour
{
    //เอาเไว้เก็บข้อมูลของสัตว์เลี้ยง
    public LayerMask layerMask;
    public bool isUiOpen = false;

    private void Update()
    {

        if (Input.GetMouseButtonDown(0) && !isUiOpen)  //คลิกที่สัตว์เลี้ยงเพื่อ เปิด UI
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 1000f, layerMask))
            {
                Debug.Log(hit.collider.name);
                UiManager.instance.openPetUI();
                isUiOpen = true;
            }
        }


        else if (Input.GetMouseButtonDown(0) && isUiOpen) //คลิกที่สัตว์เลี้ยงเหรือรอบๆเพื่อ ปิด UI
        {
            isUiOpen = false;
            UiManager.instance.closePetUI();
            //Debug.Log("Cancle Ui");
        }

    }

}
