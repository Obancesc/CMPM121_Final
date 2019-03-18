using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCylinder : MonoBehaviour
{
	public int coun = 0;
	Rigidbody rig;
	public int MiDist = 10;
	public float AttDist = 0.1F;
	public Transform playe;
	public float sped = 2F;
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
		transform.LookAt(playe);
		float distance = Vector3.Distance(transform.position, playe.position);
		if(distance < MiDist) {
			transform.position += transform.forward*sped*Time.deltaTime;
		}
		
		//Attack the player if they are in attack range
		if(distance < AttDist) 
		{
			anim.Play("Cyl_Att");
		}
		
		if(coun == 5) 
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
