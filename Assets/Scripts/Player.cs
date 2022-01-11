using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Text scoreText;
    public Text resultText;
    public AudioClip se1;
    public ItemInstantiate itemInstantiate;
    public float speed = 1;
    public GameObject gameobj;
    
    private Rigidbody _rigidbody;
    private AudioSource _audioSource;
    private int _count = 0;
    
    void Start()
    {
        _rigidbody = this.GetComponent<Rigidbody>();

        _audioSource = this.GetComponent<AudioSource>();
        
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
            _audioSource.PlayOneShot(se1);
            Destroy(other.gameObject);
        }
    }

    private void SetScoreText()
    {
        scoreText.text = "score:" + _count;
        if (_count >= gameobj.transform.childCount)
        {
            resultText.gameObject.SetActive(true);
        }
    }
}
