using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseCamera : MonoBehaviour
{
    //1.変数の定義（データを入れるための箱を作る
    public GameObject target;
    private Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        //2.代入（作成した箱の中にデータを入れる
        offset = transform.position - target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //3.活用（データの入った箱を活用する
        transform.position = target.transform.position + offset;
    }
}
