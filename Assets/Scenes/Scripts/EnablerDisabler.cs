using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablerDisabler : MonoBehaviour
{
    public AIMovement map;
    public Transform[] targets;
    public int count;


    void Update()
    {
      /*  count = map.currentIndex;
        targets = map.targets;*/
    }

    public void Disabler()
    {
        count = map.currentIndex;
        targets = map.targets;
        for (int i = 0; i < targets.Length; i++)
        {
            GameObject parent = targets[i].gameObject.transform.parent.gameObject;

            if (i == count || i == (count+1)) // Enable the current target
            {
                parent.SetActive(true);
                Debug.Log(parent.name + " is enabled");
            }
            else // Disable all other targets
            {
                parent.SetActive(false);
                Debug.Log(parent.name + " is disabled");
            }
        }
    }
}
