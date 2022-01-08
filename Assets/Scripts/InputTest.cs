using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputTest : MonoBehaviour
{
    public Text scoreText;
    public Text resultText;
    public Text timeText;
    public AudioClip se1;
    public float speed = 1;
    public float countdown = 10f;
    
    private Rigidbody _rigidbody;
    private AudioSource _audioSource;
    private int _count = 0;
    private bool _isGameFinish = false;
    
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
        
        CountDown();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Item") && !_isGameFinish)
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
    }

    private void CountDown()
    {
        if (countdown<0)
        {
            _isGameFinish = true;
            timeText.gameObject.SetActive(false);//ゲーム終了時に見えなくする
            scoreText.gameObject.SetActive(false);//ゲーム終了時に見えなくする
            resultText.gameObject.SetActive(true);//ゲーム終了時に見えるようにする
            resultText.text = scoreText.text;//ゲーム終了時のスコアをでかでかと出す
        }
        else 
        {
            //カウントダウン
            countdown -= Time.deltaTime;
            timeText.text = countdown.ToString("F1") + "秒";
        }
    }
}
