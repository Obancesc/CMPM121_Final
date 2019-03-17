using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCap : MonoBehaviour
{
	public int coun = 0;
	Rigidbody rig;
	public int MiDist = 10;
	public Transform play;
	public float speeed = 2F;
	
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		transform.LookAt(play);
		
		float distance = Vector3.Distance(transform.position, play.position);
		
		if(distance < MiDist) {
			transform.position += transform.forward*speeed*Time.deltaTime;
		}
		
		if(coun == 20) 
		{
			Destroy(gameObject);
		}
    }
	
	private void OnCollisionEnter(Collision col) 
	{
		if(col.gameObject.tag == "Weapon") 
		{
			coun++;
		}
	}
}
