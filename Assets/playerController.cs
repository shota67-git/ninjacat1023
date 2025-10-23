using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody2D rigi2d;
    Animator animator;
    public float jumpForce = 680.0f;
    public float walkForce = 30.0f;
    float maxWalkSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;//設定FPS
        rigi2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))  //按空白鍵跳躍
        {
            rigi2d.AddForce(transform.up * jumpForce);
        }
        float speedx=Mathf.Abs(rigi2d.velocity.x);//計算移動速度
                                                  //
        if (Input.GetKey(KeyCode.RightArrow)) //按右鍵移動
        {  
            transform.localScale = new Vector3(1,1,1);
            if (speedx < maxWalkSpeed) rigi2d.AddForce(transform.right * walkForce);
        }
        if (Input.GetKey(KeyCode.LeftArrow))  //按左鍵移動
        {
            transform.localScale = new Vector3(-1, 1, 1);//角色水平翻轉
            if (speedx < maxWalkSpeed)
                rigi2d.AddForce(transform.right * -walkForce);
        }
        if (transform.position.y < -4.5)  //掉到畫面外重新載入場景
            SceneManager.LoadScene("ch6");

        animator.speed = speedx/2.0f;

    }
}
