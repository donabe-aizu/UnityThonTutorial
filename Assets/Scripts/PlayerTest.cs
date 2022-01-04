using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTest : MonoBehaviour
{
    [SerializeField]
    private float speed = 1;
    
    private Rigidbody _rigidbody;
    
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
    }
    
    void Update()
    {
        _rigidbody.AddForce(Vector3.forward * Input.GetAxis("Vertical") * speed);
        _rigidbody.AddForce(Vector3.right * Input.GetAxis("Horizontal") * speed);
    }
}
