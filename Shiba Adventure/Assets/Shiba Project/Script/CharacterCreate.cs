using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CharacterCreate : MonoBehaviour
{
    //สร้าง Character
    
    [SerializeField] private TMP_InputField inputName;
    [SerializeField] private int characterIndex = 0 ;
    [SerializeField] private Button startButton;
    [SerializeField] private Button catButton;
    [SerializeField] private Button dogButton;
    [SerializeField] private Button bunnyButton;


    private void Update()
    {
        // ต้องเลือก Character เพื่อเเสดงปุ่ม Start
        if (characterIndex == 0)
        {
            startButton.gameObject.SetActive(false);
        }
        else
        {
            startButton.gameObject.SetActive(true);
        }
    }

    //กำหนด Index ของสัตว์แต่ละคัว
    public void DogIndex()
    {
        characterIndex = 1;
    }
    public void CatIndex()
    {
        characterIndex = 2;
    }
    public void BunnyIndex()
    {
        characterIndex = 3;
    }

    // ส่งชื่อและIndex ไปให้ GameManager และไป Scene GamePlay
    public void GetName()
    {
        GameManager.instance.GetCharacterName(inputName.text);
        GameManager.instance.GetCharacterIndex(characterIndex);
        SceneManager.LoadScene(1);
    }
    
}
