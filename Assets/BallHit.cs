using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallHit : MonoBehaviour
{
    private Score scoreComp;//Scoreコンポーネント

    void Start()
    {
        //シーン内のスコアコンポーネントを確保
        scoreComp = GameObject.Find("Score").GetComponent<Score>();
    }

    //衝突時処理：Scoreコンポーネントの衝突時メソッドにタグを渡す
    void OnCollisionEnter(Collision collision)
    {
        scoreComp.HitBall(collision.gameObject.tag);
    }
}
