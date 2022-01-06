using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text resultText;
    [SerializeField] private ItemInstantiate itemInstantiate;
    [SerializeField] private float speed = 1;
    
    private Rigidbody _rigidbody;
    private float _count = 0;
    
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();
        
        resultText.gameObject.SetActive(false);
        
        SetScoreText();
    }
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;
        _rigidbody.AddForce(x,0,z);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            _count++;
            SetScoreText();
            Destroy(other.gameObject);
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "score:" + _count;
        if (_count >= itemInstantiate.pointsList.Count)
        {
            resultText.gameObject.SetActive(true);
        }
    }
}
