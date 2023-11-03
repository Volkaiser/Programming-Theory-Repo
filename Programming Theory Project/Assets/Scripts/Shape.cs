using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Shape : MonoBehaviour
{
    [SerializeField]
    protected TMP_Text textBox;
    private string objectName;
    public string ObjectName
    {
        get { return objectName; }
        private set
        {
            if(value == "Sphere" || value == "Cube" || value == "Cylinder")
            {
                objectName = value;
            }
            else
            {
                Debug.LogError("This is not a valid shape.");
            }
        }
    }

    public virtual void DisplayText()
    {
        ObjectName = gameObject.name;
        textBox.text = "This is a " + ObjectName;
    }

    public string GetColor()
    {
        Color32 objectColor32 = gameObject.GetComponent<MeshRenderer>().material.color;
        string objectColor = objectColor32.ToString();
        return objectColor;
    }
}