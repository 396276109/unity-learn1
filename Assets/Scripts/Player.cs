using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // 定义一个刚体类型
    public Rigidbody rd;
    // Start is called before the first frame update
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
    private void OnCollisionEnter(Collision collision) {
        Debug.Log("碰撞检测.");
    }
    
}
