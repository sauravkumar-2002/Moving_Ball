using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class platform_script : MonoBehaviour
{
    // Start is called before the first frame update
    public int scenename;
    public int nextscene;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(Vector3.left*UnityEngine.Random.Range(0.5f,1.5f), ForceMode.VelocityChange);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
       
       if(collision.gameObject.CompareTag("candy"))
        {
               Debug.Log("colision with candy"+nextscene);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
            //SceneManager.LoadScene(nextscene);

        }

        if (collision.gameObject.CompareTag("floor"))
        {
            Debug.Log("colision with floor"+ nextscene);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
