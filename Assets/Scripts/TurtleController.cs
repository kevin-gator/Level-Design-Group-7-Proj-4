using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleController : MonoBehaviour
{
    [SerializeField] private GameObject turtle;
    [SerializeField] private GameObject player;
    [SerializeField] private Vector3 cameraPosition;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (this.rb != null)
        {
            this.rb.velocity = Vector3.zero;
            this.rb.angularVelocity = Vector3.zero;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        this.rb = player.GetComponent<Rigidbody>();
        player.GetComponent<PlayerController>().enabled = false;
        Camera.main.transform.position = cameraPosition;
        Camera.main.transform.LookAt(this.transform.position);
    }
}
