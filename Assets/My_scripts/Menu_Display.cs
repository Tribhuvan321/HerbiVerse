using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Menu_Display : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject menu;
    public Transform HMD;
    public float distance = 2.0f;
    public InputActionProperty showButton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = HMD.position + new Vector3(HMD.forward.x, 0, HMD.forward.z).normalized * distance;
        }
        menu.transform.LookAt(new Vector3(HMD.position.x, menu.transform.position.y, HMD.position.z));
        
    }
}
