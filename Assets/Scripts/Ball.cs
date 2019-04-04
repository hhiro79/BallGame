using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

    //変数の定義
    public float moveSpeed;
    public int clearCount;
    private Rigidbody rb;

    //効果音
    public AudioClip coinGet;
    public AudioClip moveFloorFind;

    //ジャンプ
    public float jumpSpeed;

    //空中ジャンプ禁止
    //boolは「真偽型」と呼ばれ「true」か「false」の2つの値を扱うことができる
    private bool isJumping = false;

    private int coinCount = 0;

    public GameObject target;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();   
    }

    // Update is called once per frame
    void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveH, 0, moveV);
        rb.AddForce(movement * moveSpeed);

        //ジャンプ（空中ジャンプ禁止）
        //「&&」は「包含関係の『かつ』の意味」
        //（例）「A && B」AかつB・・・＞AとBの両方の条件が揃った時
        //「==」は左右が等しいの意
        if(Input.GetButtonDown("Jump") && isJumping == false){
            rb.velocity = Vector3.up * jumpSpeed;

            //isJumpingの中身を「true」に
            isJumping = true;     
        }
    }

    void OnTriggerEnter(Collider col) {

        //もしもぶつかった相手に「Coin」という「Tag」が付いていたならば（条件）
        if (col.CompareTag("Coin")) {

            //ぶつかった相手を破壊する（実行）
            Destroy(col.gameObject);

            //効果音
            AudioSource.PlayClipAtPoint(coinGet, transform.position);

            //コインを1枚取得する毎に「coinCount」を1ずつ増加させる。
            coinCount++;

            if(coinCount == 2){
                //SetActive()メソッドはオブジェクトをアクティブ／非アクティブ状態にできる
                target.SetActive(true);
                //効果音
                AudioSource.PlayClipAtPoint(moveFloorFind, transform.position);
            }

            //もしも「coinCount」が「clearCount」以上になったら（条件）
            if(coinCount >= clearCount){
                //GameClearシーンに遷移する
                //遷移させるシーンは「名前」で特定するので「一言一句」合致させる
                SceneManager.LoadScene("GameClear");
            }
        }
    }

    //コインアイコン
    public int Coin(){
        return coinCount;
    }

    //ジャンプの復活
    void OnCollisionEnter(Collision col){
        
        //もしも「Floor」という「Tag」がついたオブジェクトにぶつかったら（条件）
        if(col.gameObject.CompareTag("Floor")){

            //isJumpingの箱の中のデータをfalseにする
            isJumping = false;
       }
    }
}
