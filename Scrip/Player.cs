using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{   
    public List<AudioClip> audioClips;
    AudioSource audioSource;
    public GameManager gameManager;
    // public Slider Health;
    public float timer;
    public Rigidbody2D rb;
    public float speed;
    public float jump;
    // Start is called before the first frame update
    void Start()
    {   
        audioSource = GetComponent<AudioSource>();
        // Health.maxValue=100;
        // Health.value=100;
        rb = GetComponent<Rigidbody2D>();
        speed = 5f;
        jump = 7f;
        timer = 5f;
    }
    private void FixedUpdate(){
        rb.velocity = new Vector2(speed, rb.velocity.y);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            rb.velocity = new Vector2(rb.velocity.x, jump);
            audioSource.PlayOneShot(audioClips[2]);
        }
        if(timer > 0){
            timer -= Time.deltaTime;
            
        }else{
            speed++;
            timer = 5f;
        }
        //  if(Input.GetKeyDown(KeyCode.A)){
        //     Health.value =Health.value -10;
        // }

    }
    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.CompareTag("Coin")){
            gameManager.AddScore();
            gameManager.SetScoreText();
            Destroy(collision.gameObject);
            audioSource.PlayOneShot(audioClips[0]);
            gameManager.SaveGame();
        }
        if(collision.CompareTag("Bullet")){
            Destroy(collision.gameObject);
        }
    }
}
