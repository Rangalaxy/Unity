using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Player_movment : MonoBehaviour
{
    public GameObject GameOver;
  

    Rigidbody2D player;
    bool isonground;

    Animator _state;

    public Text _scoreText;
    public Text timetxt;

    float startTime;
    int score;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
        player = GetComponent<Rigidbody2D>();
        _state = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float t = Time.time - startTime;

        string minutes = ((int)t/60).ToString();
        string seconds = (t % 60).ToString("f0");


        timetxt.text = minutes + ":" + seconds;
        _scoreText.text = "Score : " + score;


        if (Input.GetKey(KeyCode.D)) {
            transform.Translate(Vector2.right * 0.03f);
            _state.SetInteger("state", 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * 0.03f);
            _state.SetInteger("state", 1);
        }


        if (isonground)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                player.velocity = Vector2.up * 6.5f;

            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "ground")
        {
           
            isonground = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            
            isonground = false;
        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            
            GameOver.SetActive(true);
        }
        if (collision.gameObject.tag == "coin")
        {
            score++;
            Destroy(collision.gameObject);
            Debug.Log("score World");
        }
    }

}
