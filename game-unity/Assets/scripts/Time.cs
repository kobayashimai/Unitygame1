using UnityEngine; 
using UnityEngine.UI; 
 using System.Collections; 
 
 
 public class Time : MonoBehaviour { 

     public GameObject countdown;

 	private float time = 600; 
	//public ballScript BallScript; 
 	 
 	void Start () { 
		//初期値60を表示 
 		//float型からint型へCastし、String型に変換して表示 
 		GetComponent<Text>().text = ((int)time).ToString(); 
 	} 
 	 
 	void Update (){ 
 		//1秒に1ずつ減らしていく 
 		time -= 1; 
 		//マイナスは表示しない 
 		if (time < 0) time = 0; 
 		GetComponent<Text> ().text = ((int)time).ToString (); 

    if(time==300){
    Instantiate (countdown, new Vector3 (0, 0, 1), Quaternion.identity);
    }

		if(time==0){

			Application.LoadLevel("gameover");	
			
		} 
 	} 
 } 


