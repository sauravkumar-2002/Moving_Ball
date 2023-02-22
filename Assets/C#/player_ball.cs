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
        if (Input.GetKey(KeyCode.LeftArrow)) ball.AddForce(ballforce-1, 0f, 0f);
        if (Input.GetKey(KeyCode.UpArrow)) ball.AddForce(0f, 0f, -ballforce);
        if (Input.GetKey(KeyCode.DownArrow)) ball.AddForce(0f, 0f, ballforce);
        if (Input.GetKey(KeyCode.RightArrow)) ball.AddForce(-ballforce+1, 0f, 0f);
       // if (Input.GetKey("a")) ball.AddForce(ballforce, 0f, 0f);
        
        if (ball.position.y < 2)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        if(ball.position.z<-200) {
            score.text = "YOU WON";
        }
    }
}
