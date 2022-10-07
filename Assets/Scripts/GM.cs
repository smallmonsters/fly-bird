using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GM : MonoBehaviour

{
    public static float score = 0f;
    public static bool isStart = false;
    public static bool hasBird = false;
    public GameObject startBtn;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (!GM.isStart)
        {
            //隐藏开始按钮
            startBtn.SetActive(true);
        }
        if (!GM.hasBird)
        {
            //小鸟没了才销毁管子
            GameObject[] allPipe = GameObject.FindGameObjectsWithTag("pipeParenot");
            for (int i = 0; i < allPipe.Length; i++)
            {
                Destroy(allPipe[i]);
            }
        }

    }
}
