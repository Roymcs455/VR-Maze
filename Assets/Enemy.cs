using System.Collections;
using System.Collections.Generic;
using Meta.WitAi;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
    public Transform Objetivo;
    private NavMeshAgent nav;
    private GameObject trigger;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        trigger = transform.Find("Trigger").GameObject();
        trigger.AddComponent<EnemyTrigger>();
        SetTarget(Objetivo);
    }
    void SetTarget(Transform t)
    {
        nav.destination = t.position;
    }
}
