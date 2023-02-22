using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player_ball : MonoBehaviour
{
    public Rigidbody ball;
    public float ballforce;
    public Text score;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        score.text = (200f-ball.position.z).ToString();
        if (Input.GetKey("a")) ball.AddForce(ballforce, 0f, 0f);
        if (Input.GetKey("d")) ball.AddForce(-ballforce, 0f, 0f);
       // if (Input.GetKey("a")) ball.AddForce(ballforce, 0f, 0f);
        ball.AddForce(0f, 0f, -ballforce);
        if (ball.position.y < 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
