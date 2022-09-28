using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterInfo : MonoBehaviour
{
    //เอาเไว้เก็บข้อมูลและควบคุมขัตว์เลี้ยง

    [SerializeField] private InputActionReference mouseClickAction;
    
    [SerializeField] private LayerMask layerMask;

    private void OnEnable()
    {
        mouseClickAction.action.performed += ClickPet;
    }

    private void OnDisable()
    {
        mouseClickAction.action.performed -= ClickPet;
    }

    private void ClickPet(InputAction.CallbackContext click)  //คลิ๊กสัตว์เลี้ยงเปิด UI
    {
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            
        if (Physics.Raycast(ray, out hit, 1000f, layerMask))
        {
            Debug.Log("Click" + hit.collider.name);
            UiManager.instance.openPetUI();
            
        }
        
    }
    

}
