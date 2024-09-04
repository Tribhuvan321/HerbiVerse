using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using TMPro;

public class AIMovement : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    public EnablerDisabler disabler;
    public Transform[] targets;
    public int currentIndex = 0;
    private bool isMoving = false;
    public string theme;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        // Optionally start moving to the first target
        // MoveToCurrentTarget();
    }

    void Update()
    {
        // Check if the agent has reached its current destination
        if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
        {
            if (navMeshAgent.velocity.sqrMagnitude == 0f && isMoving)
            {
                Debug.Log($"Reached target: {targets[currentIndex].name}");
                isMoving = false;

                // Disable/enable targets after reaching
                disabler.Disabler();

                if (currentIndex >= targets.Length - 1)
                {
                    Debug.Log("All targets reached.");
                }
            }
        }

        if (Input.GetKeyDown(KeyCode.Space) && !isMoving && currentIndex < targets.Length)
        {
            MoveToNextTarget();
        }
    }

    public void SelectTheme(Button button)
    {
        if (button != null)
        {
            // Get the TextMeshProUGUI component from the button's children
            TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();
            if (buttonText != null)
            {
                theme = buttonText.text;
            }
        }

        GameObject[] objs = GameObject.FindGameObjectsWithTag(theme);
        List<Transform> transformList = new List<Transform>();

        foreach (GameObject obj in objs)
        {
            transformList.Add(obj.transform);
        }

        targets = transformList.ToArray();
        currentIndex = 0; // Reset the index when a new theme is selected
        MoveToCurrentTarget();
        Debug.Log($"Number of targets: {targets.Length}");
    }

    public void CanvasFunction()
    {
        if (!isMoving && currentIndex < targets.Length)
        {
            MoveToNextTarget();
        }
    }

    private void MoveToCurrentTarget()
    {   
        if (targets.Length > 0)
        {
            if(currentIndex == 0)
            {
                disabler.Disabler();
            }
            navMeshAgent.destination = targets[currentIndex].position;
            isMoving = true;
            Debug.Log($"Moving to target: {targets[currentIndex].name}");
        }
    }

    private void MoveToNextTarget()
    {
        if (currentIndex < targets.Length - 1) // Prevent index out of range
        {
            currentIndex++;
            MoveToCurrentTarget();
        }
        else
        {
            Debug.Log("No more targets to move to.");
        }
    }
}
