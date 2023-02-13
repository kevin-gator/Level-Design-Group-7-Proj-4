using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DismountTrigger : MonoBehaviour
{
    public PlayerController playerController1;
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent<PlayerController>(out PlayerController playerController))
        {
            playerController.Dismount();
            playerController1.Dismount();
        }
        if(other.gameObject.TryGetComponent<Raft>(out Raft raft))
        {
            raft.StopMoving();
            playerController1.Dismount();
        }
    }
}
