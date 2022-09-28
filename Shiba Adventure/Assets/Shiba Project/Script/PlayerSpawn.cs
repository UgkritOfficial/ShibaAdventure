using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    //เอาไว้ Spawn สัตว์
    public static PlayerSpawn instance; //Singlaton
    [SerializeField] private GameObject dogPrefab;
    [SerializeField] private GameObject catPrefab;
    [SerializeField] private GameObject bunnyPrefab;
    [SerializeField] private int thisCharacterIndex;
    [SerializeField] private Transform spawnPosition;
    
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

    private void Start()
    {
        // เรียก CharacterIndex มาจาก Gamemanager
        thisCharacterIndex = GameManager.instance.characterIndex;
        
        
        // ถ้า Index = 1 spawn dog
        if (thisCharacterIndex == 1)
        {
            Instantiate(dogPrefab, spawnPosition.position,dogPrefab.transform.rotation);
        }
        
        // ถ้า Index = 2 spawn cat
        else if (thisCharacterIndex == 2)
        {
            Instantiate(catPrefab, spawnPosition.position,spawnPosition.rotation);
        }
        
        // ถ้า Index 3 spawn bunny
        else
        {
            Instantiate(bunnyPrefab, spawnPosition.position,spawnPosition.rotation);
            
        }
        
    }
    
}
