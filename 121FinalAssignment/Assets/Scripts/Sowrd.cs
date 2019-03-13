using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sowrd : MonoBehaviour
{
	Rigidbody rigid;
	
	void Start() 
	{
		rigid = GetComponent<Rigidbody>();
	}
	
		private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Cube") 
		{
			Debug.Log("Hope this works");
			rigid.AddForce(-transform.forward * 300);
			rigid.useGravity = true;
		}
		
		if(other.gameObject.tag == "Capulse") 
		{
			Debug.Log("Capsule hit");
			rigid.AddForce(-transform.forward * 100);
			rigid.useGravity = true;
		}
		
		if(other.gameObject.tag == "Cylinder") 
		{
			Debug.Log("Cylinder down");
			rigid.AddForce(-transform.forward * 800);
			rigid.useGravity = true;
		}
	}
}
