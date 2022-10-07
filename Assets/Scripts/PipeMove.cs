using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    [SerializeField] private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GM.isStart)
        {
            // 向左匀速移动
            this.transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (this.transform.position.x < -12f)
            {
                Destroy(this.gameObject);
            }
        }
       
    }
}