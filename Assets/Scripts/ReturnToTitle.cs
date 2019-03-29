using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTitle : MonoBehaviour
{
    public float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        //任意に設定した時間の経過後、「GoTitle」メソッドを呼び出す（ポイント）
        Invoke("GoTitle", timeCount);
    }

    void GoTitle(){
        SceneManager.LoadScene("Title");
    }
}
