using UnityEngine;
using System.Collections;

public class FireControl : MonoBehaviour {
	
	//刚体 外部传入的 用于实例化（克隆）
	//放入的物体，要包含刚体才能赋值
	
	//子弹
	public Rigidbody orb;
	
	public int forceNum = 1000;
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		
		//检测是否按下鼠标左键
	    if(Input.GetMouseButtonDown(InputConst.MOUSE_LEFT) == true)
		{
			//鼠标按下
			//开火
			//print("Fire");
			
			//Instantiate  基类Object的方法
			
			//transform是表示这个脚本被添加到的物体的变换
			Rigidbody cloneRb = (Rigidbody)Instantiate(orb,transform.position,transform.rotation);//克隆一个子弹
			
			//cloneRb.transform 这个刚体被添加到的物体上的变换
			//cloneRb.transform.forward
			cloneRb.AddForce(cloneRb.transform.forward*forceNum);
		}
	}
}
