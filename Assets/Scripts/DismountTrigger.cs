using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DismountTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            playerController.Dismount();
        }
        if(other.gameObject.TryGetComponent<Raft>(out Raft raft))
        {
            raft.StopMoving();
        }
    }
}
