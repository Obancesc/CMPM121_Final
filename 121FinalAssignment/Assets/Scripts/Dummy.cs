using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
	public int count = 0;
	public int MinDist = 100;
	Rigidbody rb;
	public Transform player;
	public float speed = 1f;
		
    void Start()
    {
     //   hit = GetComponent<Animation>();
	 rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
		transform.LookAt(player);
		//Debug.Log("Come here");
		float distance = Vector3.Distance(transform.position, player.position);
		if(distance < MinDist) {
			transform.position += transform.forward*speed*Time.deltaTime;
		}

		if(count == 14) 
		{
			Destroy(gameObject);
		}
		
		
       //GetComponent<Animator>().Play("Get_Hit");
    }
	
	private void OnCollisionEnter(Collision other) 
	{
		if(other.gameObject.tag == "Weapon") 
		{
			count++;
		}
	}
}
