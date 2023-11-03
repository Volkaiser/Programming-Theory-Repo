using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    public TMP_Text textBox;

    private void OnMouseDown()
    {
        string objectName = gameObject.name;
        Color32 objectColor32 = gameObject.GetComponent<MeshRenderer>().material.color;
        string objectColor = objectColor32.ToString();
        switch (objectName)
        {
            case "Cylinder":
                textBox.text = "This is a " + objectName + " and it is " + objectColor;
                break;
            case "Cube":
                textBox.text = "This is " + objectColor;
                break;
            case "Sphere":
                textBox.text = "This is a " + objectName;
                break;
            default:
                textBox.text = "Default";
                break;
        }
    }
}