using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public Rigidbody rd;
    public int score = 0;
    public Text scoreText;
    public GameObject Win;
    // Start is called before the first frame update
    void Start()
    {
        //Debug.Log("游戏开始了");
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v));
    }


    //private void OnCollisionEnter(Collision collision)
    //{
    //    Debug.Log("发生碰撞了 OnCollisionEnter");

    //    //collision.collider.tag;

    //    if(collision.gameObject.tag == "Food")
    //    {
    //        Destroy(collision.gameObject);
    //    }

    //}

    //private void OnCollisionExit(Collision collision)
    //{
    //    Debug.Log("发生碰撞了 OnCollisionExit");
    //}

    //private void OnCollisionStay(Collision collision)
    //{
    //    Debug.Log("发生碰撞了 OnCollisionStay");
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            Destroy(other.gameObject);
            score++;

            scoreText.text = "Score: " + score;
            if (score == 12)
            {
                Win.SetActive(true);
            }
        }
    }
}
