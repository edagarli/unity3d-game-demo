using UnityEngine;
using System.Collections;

public class MoveControl : MonoBehaviour {
	
	public float moveNum = 0.2f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
		float hChange = Input.GetAxis(InputConst.Horizontal);
	   if(hChange!=0)
		{
			Vector3 op;
			op = transform.position;
			if(hChange>0)
			{
				//按下了向右键
				//物体向右移动
				//控制物体的位置。通过transform组建
				//MonoBehaviour 提供了transform这个属性
				
				op.x += moveNum; //控制移动的位置
				
			}else 
			{
				//按下了向左键
				//物体向左移动
				op.x -= moveNum; //控制移动的位置
			}
			
			transform.position = op; //使用新的位置赋予变换组建的postion
		}
		
		float vChange = Input.GetAxis(InputConst.Vertical);
		if(vChange!= 0)
		{
			//在前后方向有输入
			
			Vector3 op;
			op = transform.position;
			if(vChange>0)
			{
				//按下向前键，物体向前移动
				op.z += moveNum;
			}else
			{
				op.z -= moveNum;
			}
			
			transform.position = op;
			
		}
	} 

	
}
