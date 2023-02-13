using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raft : MonoBehaviour
{
    public bool isMoving;

    [SerializeField]
    private float _speed;

    [SerializeField]
    private Rigidbody _rb;
    
    // Start is called before the first frame update
    void Start()
    {
        isMoving = true;
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(isMoving)
        {
            _rb.velocity = new Vector3(_rb.velocity.x, _rb.velocity.y, _speed);
        }
        else
        {
            _rb.velocity = Vector3.zero;
        }
    }

    public void StopMoving()
    {
        isMoving = false;
    }
}
