using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TMP_Text textBox;

    public virtual void DisplayText()
    {
        string objectName = gameObject.name;
        textBox.text = "This is a " + objectName;
    }
}