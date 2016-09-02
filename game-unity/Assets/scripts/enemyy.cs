using UnityEngine;
using System.Collections;

/// 敵
public class enemyy : Token
{
	public GameObject enemyy2;
    /// 開始
    void Start()
    {
        // サイズを設定
        SetSize(SpriteWidth / 2, SpriteHeight / 2);

        // ランダムな方向に移動する
        // 方向をランダムに決める
        float dir = Random.Range(0, 359);
        // 速さ
        float spd = 20;
        SetVelocity(dir, spd);
    }

    public void OnMouseDown()
    {

		 Invoke("Destroy", 0.1f);
		
		float x = Random.Range(0.0f, 2.0f);
		float y = Random.Range(0.0f, 2.0f);
		float z = Random.Range(0.0f, 2.0f);		
		//オブジェクトを生産
		Instantiate(enemyy2, new Vector3(x, y, z), Quaternion.identity);
	}

    void Destroy()
    {
        // 破棄する
        DestroyObj();
    }

    void Update()
    {

        // カメラの左下座標を取得
        Vector2 min = GetWorldMin();
        // カメラの右上座標を取得する
        Vector2 max = GetWorldMax();

        if (X < min.x || max.x < X)
        {
            // 画面外に出たので、X移動量を反転する
            VX *= -1;
            // 画面内に移動する
            ClampScreen();
        }
        if (Y < min.y || max.y < Y)
        {
            // 画面外に出たので、Y移動量を反転する
            VY *= -1;
            // 画面内に移動する
            ClampScreen();
        }
    }
}

