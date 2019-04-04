using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text timeLabel;
    public float timeCount;

    //コインアイコン
    //配列（複数のデータを入れることのできる仕切りのある箱）
    public GameObject[] icons;
    private Ball ballScript;

    // Start is called before the first frame update
    void Start()
    {
        timeLabel.text = "TIME;" + timeCount;

        //コインアイコン
        //「Ball」オブジェクトに付いている「Ball」スクリプトにアクセス
        ballScript = GameObject.Find("Ball").GetComponent<Ball>();
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;

        //ToString("0")は小数点切り捨て
        //小数点1位まで表示するにはToString("n1")
        //小数点2位まで表示するにはToString("n2")
        timeLabel.text = "TIME;" + timeCount.ToString("0");

        if(timeCount < 0){
            SceneManager.LoadScene("GameOver");
        }

        //コインアイコン
        UpdateCoin(ballScript.Coin());
    }

    //コインアイコンを表示するメソッド
    void UpdateCoin(int coin){

        //for文（繰り返し）
        for(int i = 0; i < icons.Length; i++){
            if(coin <= i){

                //コインアイコンを表示状態に
                icons[i].SetActive(true);
            } else {

                //コインアイコンを非表示状態に
                icons[i].SetActive(false);
            }
        }
    }
}
