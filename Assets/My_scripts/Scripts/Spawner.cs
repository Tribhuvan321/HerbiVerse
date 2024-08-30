using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public GameObject leftController;
    public bool spawned = false;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        if ((other.name == "Left Controller" || other.name == "Right Controller") && spawned == false)
        {
            GameObject SpawnedPrefab = Instantiate(prefab);
            spawned = true;
            SpawnedPrefab.transform.position = leftController.transform.position;
            SpawnedPrefab.transform.rotation = leftController.transform.rotation;
        }

    }
}