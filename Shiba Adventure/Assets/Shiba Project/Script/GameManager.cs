using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    // ควบคุมตัวเกม
    public static GameManager instance; //Singlaton
    public string characterName;
    public int characterIndex;
    
    private void Awake() //Singlaton
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }
    

    public void GetCharacterName(string name)
    {
        //   รับชื่อจาก CharacterCreate
        characterName = name;
    }
    public void GetCharacterIndex(int index)
    {
        // รับ index ของสัตว์ จาก CharacterCreate
        characterIndex = index;
    }
    
    
}
