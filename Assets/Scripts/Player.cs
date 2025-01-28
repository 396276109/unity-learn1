using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    // 定义一个刚体类型
    public Rigidbody rd;
    int score = 0;
    public Text scoreText;
    public GameObject winText;

    void Start()
    {   
        // 游戏开始，将刚体组件赋值给rd
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        // 给rd施加一个向右的力，默认为1牛的力
        // rd.AddForce(Vector3.right);
        // 施加2牛的力
        // rd.AddForce(new Vector3(10,0,0));
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h,0,v));

    }
    // private void OnCollisionEnter(Collision collision) {
    //     if (collision.gameObject.tag == "food")
    //     {
    //         Destroy(collision.gameObject);
    //     }
    // }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "food")
        {
            score ++;
            scoreText.text = "当前分数："+score;
            Destroy(other.gameObject);
            if (score>=7)
            {
                winText.SetActive(true);
            }
        }
    }
}
