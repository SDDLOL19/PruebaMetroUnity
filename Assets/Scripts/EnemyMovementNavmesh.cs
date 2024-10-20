using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovementNavmesh : MonoBehaviour
{
    [SerializeField] Transform objetivoPlayer;
    [SerializeField] float distanciaMin, velocidad, ralentizacion;
    NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = velocidad;
        agent.stoppingDistance = distanciaMin;
        agent.acceleration = ralentizacion;
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(objetivoPlayer.position); 
    }

    
}

