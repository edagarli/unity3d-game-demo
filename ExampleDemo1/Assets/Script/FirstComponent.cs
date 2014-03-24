using UnityEngine;
using System.Collections;

public class FirstComponent : MonoBehaviour 
{
	private int _count = 0;
	
	// 总共的次数
	public int TotalCount = 5;
	
	public bool IsControl = false;
	
	public Vector3 positonV;
	
	// Use this for initialization
	void Start ()
	{
	 // this.enabled = false;
	  print("Use is for initialization");
	}
	
	// Update is called once per frame
	//每一帧调用
	void Update () 
	{
		_count++;
		if(_count>TotalCount)
		{
			if(IsControl)
			{
				//执行5帧之后不再执行这个脚本
			    this.enabled = false;
			}
			
		}
	   print("Update is called once per frame");
	}
}
