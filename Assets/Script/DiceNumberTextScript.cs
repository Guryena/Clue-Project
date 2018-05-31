using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class DiceNumberTextScript : MonoBehaviour
{
    Text text;
    public static int BlackdiceNumber;
    public static int WhitediceNumber;
    
    //Use this for initialization
    void Start()
    {
        text = GetComponent<Text>();

    }

    //Update is called once per frame
    void Update()
    {
        int value = BlackdiceNumber + WhitediceNumber;

        text.text = value.ToString();

        //text.text = BlackdiceNumber.ToString()+WhitediceNumber.ToString();

    }

}
