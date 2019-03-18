using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCap : MonoBehaviour
{
	public int coun = 0;
	Rigidbody rig;
	public int MiDist = 10;
	public float AttkDist = 0.1F;
	public Transform play;
	public float speeed = 2F;
	private Animation anim;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
		anim = gameObject.GetComponent<Animation>();
    }

    // Update is called once per frame
    void Update()
    {
		transform.LookAt(play);
		
		float distance = Vector3.Distance(transform.position, play.position);
		
		if(distance < MiDist) {
			transform.position += transform.forward*speeed*Time.deltaTime;
		}
		
		if(distance < AttkDist) 
		{
			anim.Play("Cap_Att");
		}
		
		if(coun == 15) 
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
