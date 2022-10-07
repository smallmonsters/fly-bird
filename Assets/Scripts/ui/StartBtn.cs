using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StartBtn : MonoBehaviour
{
    Button startBtn;
    public GameObject bird;
    // Start is called before the first frame update
    void Start()
    {
        startBtn = this.GetComponent<Button>();        
    }

    // Update is called once per frame
    void Update()
    {
        startBtn.onClick.AddListener(startGame);
    }
    void startGame()
    {
        //游戏开始
        GM.isStart = true;
        if (!GM.hasBird)
        {
            Instantiate(bird, new Vector2(-9.89f, 2.87f), transform.rotation);
            GM.hasBird = true;
        }
        //重置分数
        GM.score = 0;
        this.gameObject.SetActive(false);


    }
}
