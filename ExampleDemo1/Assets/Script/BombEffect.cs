using UnityEngine;
using System.Collections;

//组件的作用
//当碰撞发生的时候。在碰撞的位置，创建一个爆炸效果
public class BombEffect : MonoBehaviour {
	
	public Transform bombEffect;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	//当子弹和墙体碰到一起的时候。执行这个函数
	//在碰撞的地方，添加一个爆炸的效果
	void OnCollisionEnter(Collision collision) 
	{
	   //Collision.transform
		Transform collTransform = collision.transform;//碰撞时刻的位置
		Transform cloneBombEffect = (Transform)Instantiate(bombEffect,collTransform.position,collTransform.rotation);//在碰撞时刻的位置，克隆一个爆炸效果
		
		//当导弹碰到墙体的时候。导弹它自己要销毁
		
		Destroy(cloneBombEffect.gameObject,2.0f);//两秒之后。销毁爆炸特效
		
		//gameObject表示的是这个脚本附加的物体
		Destroy(gameObject);
		
	}
}
