using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text timeLabel;
    public float timeCount;

    // Start is called before the first frame update
    void Start()
    {
        timeLabel.text = "TIME;" + timeCount;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount -= Time.deltaTime;

        //ToString("0")は小数点切り捨て
        //小数点1位まで表示するにはToString("n1")
        //小数点2位まで表示するにはToString("n2")
        timeLabel.text = "Time;" + timeCount.ToString("0");

        if(timeCount < 0){
            SceneManager.LoadScene("GameOver");
        }
    }
}
