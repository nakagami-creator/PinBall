using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;//Text用変数

    private int score = 0;//スコア計算用変数

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        SetScore();//初期スコアを代入して表示
    }


    //当たったオブジェクトのタグを渡される
    public void HitBall(string hittag)
    {
        if (hittag == "LargeStarTag")
        {
            score += 100;
        }
        else if (hittag == "LargeCloudTag")
        {
            score += 50;
        }
        else if (hittag == "SmallCloudTag")
        {
            score += 30;
        }
        else
        {
            score += 0;
        }

        SetScore();
    }

    void SetScore()
    {
        scoreText.text = string.Format("Score:{0}", score);
    }
}



