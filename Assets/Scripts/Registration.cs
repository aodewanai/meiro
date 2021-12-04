using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Registration : MonoBehaviour
{
    public InputField inputName;
    //public Text textName;

    public void SetName()
    {
        DataHolder.name = inputName.text;
        inputName.text = "success!!!";
    }

}
