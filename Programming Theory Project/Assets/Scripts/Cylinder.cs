using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    private void OnMouseDown()
    {
        DisplayText();
    }

    public override void DisplayText()
    {
        base.DisplayText();
        Color32 objectColor32 = gameObject.GetComponent<MeshRenderer>().material.color;
        string objectColor = objectColor32.ToString();
        string currentText = textBox.text;
        textBox.text = currentText + " and it is " + objectColor;
    }
}