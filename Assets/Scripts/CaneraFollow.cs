using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaneraFollow : MonoBehaviour
{
    // 获取球球位置
    public Transform playerTransform;
    // 设置偏移量
    private Vector3 offset;


    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - playerTransform.position;
    }

    // Update is called once per frame
    void Update()
    {   
        // 思路就是相机直接等于球球那就是相机位置直接 == 球球位置，把球球跟相机之间的距离重新加上就是原相机的位置
        transform.position = playerTransform.position+offset;
    }
}
