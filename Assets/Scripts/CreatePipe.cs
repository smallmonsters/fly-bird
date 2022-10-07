using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatePipe : MonoBehaviour
{
    public GameObject pipe;
    //冷却时间
    [SerializeField] private float cold = 2f;
    private float next;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame，每一帧需要做的事情
    void Update()
    {
        if (GM.isStart)
        {
            if (Time.time > next)
            {
                next = Time.time + cold;
                //获取当前预制体的位置
                Vector2 pos = this.transform.position;
                //给预制体随机一个y轴
                pos.y = Random.Range(5f, 9.5f);
                //实例化一个预制体
                Instantiate(pipe, pos, transform.rotation);

            }
        }

    }
}
