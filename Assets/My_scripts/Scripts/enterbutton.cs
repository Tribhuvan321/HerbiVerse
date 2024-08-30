using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class enterbutton : MonoBehaviour
{
    public GameObject inputFieldObject;  // Reference to the GameObject with TMP_InputField
    public GameObject inputFieldObject1;
    public GameObject keyboard;
    private TMP_InputField inputField;
    private TMP_InputField inputField1;

    public void Start()
    {
        inputField = inputFieldObject.GetComponent<TMP_InputField>();
        inputField1 = inputFieldObject1.GetComponent<TMP_InputField>();
    }

    private void Update()
    {
        string enteredText = inputField.text;
        inputField1.text = enteredText;
    }

    public void saveText()
    {
        keyboard.SetActive(false);
    }

}
