using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCap : MonoBehaviour
{
	public int coun = 0;
	Rigidbody rig;
	
	
    // Start is called before the first frame update
    void Start()
    {
        rig = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
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
