using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    //ควบคุม UI
    
    public static UiManager instance; //Singlaton
    public TextMeshProUGUI characterName;
    public GameObject petUi;
    public Button foodButton;
    public Button showerButton;
    public Button patButton;
    
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
    }
   
    void Start()
    {
        characterName.text = GameManager.instance.characterName; // รับชื่อมาจาก GameManager และ แสดงบนหัวสัตว์เลี้ยง
        petUi.gameObject.SetActive(false); //ปิด UI อาหาร อาบน้ำ ลูบหัว
    }

   public void openPetUI() //เปิด UI อาหาร อาบน้ำ ลูบหัว
    {
        petUi.gameObject.SetActive(true);
    }
   public void closePetUI() //ปิด UI อาหาร อาบน้ำ ลูบหัว
   {
       petUi.gameObject.SetActive(false);
   }
}
