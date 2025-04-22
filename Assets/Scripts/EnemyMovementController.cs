using System;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.LowLevel;

public class EnemyMovementController : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private Vector3[] patrollingLocations;
    private int locationIndex = 0;
    private Vector3 currentTarget;

    public Action OnPlayerSpotted;
    public Action OnPlayerLost;


    private NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentTarget = patrollingLocations[0];
        agent.SetDestination(currentTarget);
    }

    private void OnEnable()
    {
        OnPlayerSpotted += PlayerSpotted;
        OnPlayerLost += PlayerLost;
    }

    private void OnDisable()
    {
        OnPlayerSpotted -= PlayerSpotted;
        OnPlayerLost -= PlayerLost;
    }

    private void PlayerLost()
    {
        agent.isStopped = false;
    }

    private void PlayerSpotted()
    {
        agent.isStopped = true;
    }

    private void Update()
    {
        if (AreWeThereYet())
            NextLocation();
    }

    private void NextLocation()
    {
        locationIndex++;
        if (locationIndex >= patrollingLocations.Length)
            locationIndex = 0;

        currentTarget = patrollingLocations[locationIndex];
        agent.SetDestination(currentTarget);
    }

    private bool AreWeThereYet()
    {
        return Vector3.Distance(transform.position, currentTarget) <= 0.2f;
    }
}
