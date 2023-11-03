using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : Shape
{
    private void OnMouseDown()
    {
        DisplayText();
    }

    public override void DisplayText()
    {
        Color32 objectColor32 = gameObject.GetComponent<MeshRenderer>().material.color;
        string objectColor = objectColor32.ToString();
        textBox.text = "This is " + objectColor;
    }
}