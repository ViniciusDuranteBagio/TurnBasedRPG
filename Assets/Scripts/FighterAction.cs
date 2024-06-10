using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FighterAction : MonoBehaviour
{
    private GameObject enemy;
    private GameObject hero;
    
    [SerializeField]
    private GameObject meleePrefab;
    
    [SerializeField]
    private GameObject rangePrefab;
    
    [SerializeField]
    private Sprite faceIcon;

    private GameObject currentAttack;
    private GameObject meleeAttack;
    private GameObject rangeAttack;

    public void SelectAttack(string btn)
    {
        GameObject victim = tag == "Hero" ? enemy : hero;
        
        switch (btn)
        {
            case "melee":
                Debug.Log("Melee");
                // currentAttack = meleeAttack;
                break;
            case "range":
                Debug.Log("Range");
                // currentAttack = rangeAttack;
                break;
            case "magic" :
                Debug.Log("Casting a magic spell!");
                break;
            case "run":
                Debug.Log("Running");
                break;
        }
    }
}
