using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    Rigidbody rigid;
    public float forwardSpeed = 3.0F;
    public float backwardSpeed = 2.5F;
    public float rotateSpeed = 2.0F;
    private Vector3 velo;
	private Animator anim;
	public float animSpeed = 1.5F;
	public int win = 0;
	public Text text;
	
	//public GameObject cube;
	public float death = 25;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
		anim = GetComponent<Animator>();
    }

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
		
		if(Input.GetKeyDown(KeyCode.P))
		{
			GetComponent<Animator>().Play("Swing_4");
		}
		
		if(Input.GetKeyDown(KeyCode.R))
		{
			Application.LoadLevel(Application.loadedLevel);
		}
		
		if(death < 0) 
		{
			Destroy(gameObject);
			Application.LoadLevel(2);
		}
    }
	
	
	
		private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Cylinder") 
		{
			death -= 0.75F;
			text.text = death.ToString();
		}
		
		if(other.gameObject.tag == "Capulse") {
			death -= 1.5F;
			text.text = death.ToString();
		}
		
		if(other.gameObject.tag == "Cube") 
		{
			death--;
			text.text = death.ToString();
		}
	}
}
