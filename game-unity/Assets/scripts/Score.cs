using UnityEngine; 
using System.Collections; 
using UnityEngine.UI; 

 public class Score : MonoBehaviour { 
 
	public GameObject enemyy;

public Text scoreText; //Text用変数 
private int score = 0; //スコア計算用変数 

private Transform playerTrans; 

void Start (){ 

		scoreText.text = "Score: 0"; //初期スコアを代入して画面に表示 
	}
 
	void CountDown() { 		 		
		scoreText.text = "Score: " + score.ToString();
		 	} 

void Update (){ 

		//タッチ検出
		if (Input.GetMouseButtonDown(0))
		{
			
			//タッチ座標を取得
			Vector3 aTapPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//タッチ座標のコライダーを検出
			Collider2D aCollider2d = Physics2D.OverlapPoint(aTapPoint);


			//コライダーを検出した場合
				if (aCollider2d)
			{
				//そのゲームオブジェクトを取得
				GameObject obj = aCollider2d.gameObject;
				Debug.Log (obj.gameObject.tag);

                if (obj.gameObject.tag == "enemyy")
				{
				score += 5; //scoreに加算 
				//スコアを更新して表示 
				scoreText.text = "Score: " + score.ToString();

	} 
				if (obj.gameObject.tag == "enemyg")
				{
				score += 10; //scoreに加算 
				//スコアを更新して表示 
				scoreText.text = "Score: " + score.ToString();

	} 
                if (obj.gameObject.tag == "enemyp")
				{
				score += 20; //scoreに加算 
				//スコアを更新して表示 
				scoreText.text = "Score: " + score.ToString();

	} 
}
		}

	}


}
	


