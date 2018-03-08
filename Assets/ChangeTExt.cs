using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ChangeTExt : MonoBehaviour
{

    public Text mytext = null;
    public int counter = 0;
    public void changeText()
    {
        counter++;
        mytext.text = "Gold: " + Convert.ToString(counter);
    }
}
