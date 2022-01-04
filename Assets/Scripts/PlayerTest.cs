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
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        _rigidbody.AddForce(x,0,z);
    }
}
