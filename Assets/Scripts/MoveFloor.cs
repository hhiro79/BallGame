using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFloor : MonoBehaviour
{
    public float len_x;
    public float len_y;
    public float len_z;
    public float moveX;
    private Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        //MoveFloorオブジェクトの位置情報をposの中に代入する
        pos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Mathf.PingPong(float t, float length);
        //tの値を0からlengthの範囲内で行ったり来たりさせる
        this.gameObject.transform.position = new Vector3(pos.x + (Mathf.PingPong(Time.time, len_x) * moveX),
         pos.y + Mathf.PingPong(Time.time, len_y), pos.z + Mathf.PingPong(Time.time, len_z) );
    }
}
