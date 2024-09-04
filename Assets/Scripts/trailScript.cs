using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;

public class trailScript : MonoBehaviour
{
    public List<Transform> destinations;  // List of destinations to move to
    private NavMeshAgent agent;  // Reference to the NavMeshAgent component
    private int currentDestinationIndex = 0;  // Index to track the current destination

    void Start()
    {
        // Get the NavMeshAgent component attached to this GameObject
        agent = GetComponent<NavMeshAgent>();

        if (agent == null)
        {
            Debug.LogError("NavMeshAgent component is missing from this GameObject.");
            return;
        }

        if (destinations == null || destinations.Count == 0)
        {
            Debug.LogError("No destinations assigned.");
            return;
        }

        // Set the initial destination
        MoveToNextDestination();
    }

    void Update()
    {
        /*// Check if the agent has reached the destination
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            // Check for user input to move to the next destination
            if (Input.GetKeyDown(KeyCode.Space))
            {
                MoveToNextDestination();
            }
        }*/
    }

    public void MoveToNextDestination()
    {
        if (destinations.Count == 0)
            return;

        // Move to the next destination
        agent.SetDestination(destinations[currentDestinationIndex].position);

        // Update index to the next destination
        currentDestinationIndex = (currentDestinationIndex + 1) % destinations.Count;
    }
}
