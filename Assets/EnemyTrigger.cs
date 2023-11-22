using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTrigger : MonoBehaviour
{
    void OnTriggerEnter(Collider col)
    {
        Debug.Log("Algo entró");
        SendMessageUpwards("SetTarget",col.transform.position);
    }
    
}
