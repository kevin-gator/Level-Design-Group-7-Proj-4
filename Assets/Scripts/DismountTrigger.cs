using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DismountTrigger : MonoBehaviour
{
    public Raft raft;

    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            playerController.Dismount();
            raft.StopMoving();
        }
    }
}
