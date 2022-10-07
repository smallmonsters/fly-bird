using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //小鸟的钢体组件
    Rigidbody2D birdRig;
    //小鸟所有的音频
    AudioSource birdAudioSource;
    //小鸟飞行的音频
    public AudioClip flyClip;
    //小鸟碰到管子的音频
    public AudioClip hitClip;
    //点击小鸟飞多高
    [SerializeField] private float force = 200f;
    // Start is called before the first frame update
    void Start()
    {
        birdRig = this.GetComponent<Rigidbody2D>();
        birdAudioSource = this.GetComponent<AudioSource>();
    }

    void Update()
    {
        if (GM.isStart)
            birdRig.gravityScale = 1f;
        {
            //点击鼠标左键，小鸟向上移
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                birdRig.AddForce(force * Vector2.up);
                birdAudioSource.clip = flyClip;
                birdAudioSource.Play();
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (GM.isStart)
        {
            //小鸟撞到了管子
            if (collision.collider.tag == "pipe")
            {
                Debug.Log("Game Over");
                birdAudioSource.clip = hitClip;
                birdAudioSource.Play();
                //this.gameObject.SetActive(false);
                Invoke("OnDestroy", 0.45f);
            }
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //小鸟得分了
        if (collision.tag == "score")
        {
            GM.score += 1;
        }
    }

    private void OnDestroy()
    {
        GM.hasBird = false;
        GM.isStart = false;
        Destroy(this.gameObject);
    }
}
