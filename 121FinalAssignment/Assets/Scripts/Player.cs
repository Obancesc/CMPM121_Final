using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public float forwardSpeed = 3.0F;
    public float backwardSpeed = 2.0F;
    public float rotateSpeed = 2.0F;
    private Vector3 velo;
	private Animator anim;
	public float animSpeed = 1.5F;
	
	public GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
		anim.SetFloat("Speed", v);
		anim.SetFloat("Direction", h);
		anim.speed = animSpeed;

        velo = new Vector3(0, 0, v);
        velo = transform.TransformDirection(velo);
        if(v > 0.1)
        {
            velo *= forwardSpeed;
        } else if (v < -0.1) {
            velo *= backwardSpeed;
        }

        transform.localPosition += velo * Time.fixedDeltaTime;
       transform.Rotate(0, h * rotateSpeed, 0);

        if(Input.GetKeyDown(KeyCode.I))
        {
            GetComponent<Animator>().Play("Swing_2_2");
            if(Input.GetKeyDown(KeyCode.I))
            {
                GetComponent<Animator>().Play("Swing_2");
            }
        }

        if(Input.GetKeyDown(KeyCode.O))
        {
            GetComponent<Animator>().Play("Swing_2_3");
        }

       /* if(Input.GetKeyDown(KeyCode.P))
        {
            GetComponent<Animator>().Play("Swing_3");
        }*/
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			GetComponent<Animator>().Play("Swing_4");
			//rigid.AddForce(new Vector3(0,1,0) * 10F);
		}
		
		if(Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
    }
	
		/*private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Cube") 
		{
		Debug.Log("Hope this works");
		rigid.AddForce(-transform.forward * 2000);
		rigid.useGravity = true;
		}
	}*/
}
