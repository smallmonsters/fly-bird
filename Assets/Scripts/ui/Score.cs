using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "得分：" + GM.score.ToString();
    }
}
