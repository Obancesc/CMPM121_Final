using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
	public Button GameOverDang;
	
    // Start is called before the first frame update
    void Start()
    {
        GameOverDang.onClick.AddListener(GameOverClick);
    }

	void GameOverClick() 
	{
		Application.LoadLevel(1);
	}
}
