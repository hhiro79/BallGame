using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarpPoint : MonoBehaviour
{
    public Vector3 pos;

    void OnTriggerEnter(Collider col){
        //(考え方)触れた瞬間にボールに新しい位置情報をセットする。
        //「0.5f」のように「少数」を使用する場合には必ず「ｆ」を書くこと
        //「ｆ」は「float（浮動小数点）」の略
        col.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
