using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallBlock : MonoBehaviour
{
    //変数の定義（データを入れる箱を作る）
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        //代入（箱の中にデータを入れる）   
        rb = GetComponent<Rigidbody>();
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.CompareTag("Player")){

            //(ポイント)Invoke("呼び出すメソッド名"、呼び出すまでの時間)
            //Fallという名前のメソッドを2秒後に呼び出す
            Invoke("Fall", 0.5f);
        }
    }

    void Fall(){

        //(ポイント)isKinematicを無効化する
        rb.isKinematic = false;
    }
}
