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

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody>();		
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

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
    }
}
