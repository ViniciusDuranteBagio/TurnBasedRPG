using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeButton : MonoBehaviour
{
    [SerializeField] private bool physical;
    private GameObject _hero;
    void Start()
    {
        string buttonName = gameObject.name;
        gameObject.GetComponent<Button>().onClick.AddListener(() => AttachCallback(buttonName));
        _hero = GameObject.FindWithTag("Hero"); // TODO criar essa tag
    }

    void AttachCallback(string buttonName)
    {
        switch (buttonName)
        {
            case "MeleeAttackBtn":
                _hero.GetComponent<FighterAction>().SelectAttack("melee");
                break;
            case "RangeAttackBtn":
                _hero.GetComponent<FighterAction>().SelectAttack("range");
                break;
            case "MagicAttackBtn":
                _hero.GetComponent<FighterAction>().SelectAttack("magic");
                break;
            case "RunBtn":
                Debug.Log("Run Button Clicked");
                break;
        }
    }
}
