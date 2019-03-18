using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class YouWinn : MonoBehaviour
{
	public Button Win;
    // Start is called before the first frame update
    void Start()
    {
        Win.onClick.AddListener(WinClick);
    }

	void WinClick() 
	{
		Application.LoadLevel(1);
	}
}
