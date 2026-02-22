using UnityEngine;
using TMPro;

public class Birdy : MonoBehaviour
{
    public AudioSource gameOver;
    public AudioSource jumpSound;
    public GameObject DeathScreen;
    public float velocity = 1f;
    private Rigidbody2D rb2D;
    public bool isDead;
    public GameManage manageGame; 
    void Start()
    {
        rb2D = GetComponent<Rigidbody2D>();
        Time.timeScale = 1f;
        DeathScreen.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb2D.linearVelocity = Vector2.up * velocity;
            jumpSound.Play();
        }
        float mapSinir = Mathf.Clamp(transform.position.y, -1.3f, 1.3f);

        transform.position = new Vector3(transform.position.x, mapSinir ,transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        isDead = true;
        DeathScreen.SetActive(true);
        gameOver.Play();
        Time.timeScale = 0;
       

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("puan"))
        {
            manageGame.UpdateScore();
        }
    }
}
