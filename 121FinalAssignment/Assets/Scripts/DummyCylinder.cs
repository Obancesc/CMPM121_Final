using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyCylinder : MonoBehaviour
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
