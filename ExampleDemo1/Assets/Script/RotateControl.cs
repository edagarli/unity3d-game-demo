using UnityEngine;
using System.Collections;

public class RotateControl : MonoBehaviour {
	
	//旋转的数值
	public float rotateNum = 1.0f;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	    float xChange = Input.GetAxis(InputConst.MouseX);//鼠标再水平方向移动的数值
		float yChange = Input.GetAxis(InputConst.MouseY);//鼠标再垂直方向移动的数值
		
		print("xChange = "+xChange+"     yChange = "+yChange);
		
		//Rotate 绕轴3旋转物体
		transform.Rotate(-yChange*rotateNum,xChange*rotateNum,0);
	}
}
