using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class keyBoardDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject keyboard;
    public Transform HMD;
    public float distance = 1.5f;

    // Update is called once per frame
    public void keyBoardDisplayEnable()
    {
        keyboard.SetActive(!keyboard.activeSelf);
        keyboard.transform.position = HMD.position + new Vector3(HMD.forward.x, 0, HMD.forward.z).normalized * distance;
        keyboard.transform.LookAt(new Vector3(HMD.position.x, keyboard.transform.position.y, HMD.position.z));
        keyboard.transform.Rotate(new Vector3(0, 1, 0) * 180);

    }
}
