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
	public float AttDist = 0.5F;
	private Animation anim;
	
		
    void Start()
    {
     //   hit = GetComponent<Animation>();
	 rb = GetComponent<Rigidbody>();
	 anim = gameObject.GetComponent<Animation>();
    }

    void Update()
    {
		transform.LookAt(player);
		//Debug.Log("Come here");
		float distance = Vector3.Distance(transform.position, player.position);
		if(distance < MinDist) {
			transform.position += transform.forward*speed*Time.deltaTime;
		}
		
		if(distance < AttDist) 
		{
			anim.Play("Cub_Att");
		}

		if(count == 10) 
		{
			Destroy(gameObject);
		}
    }
	
	private void OnCollisionEnter(Collision other) 
	{
		if(other.gameObject.tag == "Weapon") 
		{
			count++;
		}
	}
}
