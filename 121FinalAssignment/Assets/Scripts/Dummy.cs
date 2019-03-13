using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dummy : MonoBehaviour
{
	public int count = 0;
	Rigidbody rb;
		
    // Start is called before the first frame update
    void Start()
    {
     //   hit = GetComponent<Animation>();
	 rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
