using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCylinder : MonoBehaviour
{
	public int coun = 0;
	Rigidbody rig;
	public int MiDist = 10;
	public Transform playe;
	public float sped = 2F;
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		transform.LookAt(playe);
		float distance = Vector3.Distance(transform.position, playe.position);
		if(distance < MiDist) {
			transform.position += transform.forward*sped*Time.deltaTime;
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
