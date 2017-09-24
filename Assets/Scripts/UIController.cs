using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour 
{
	public Text GameClearLabel;

	private void Start () 
	{
		GameClearLabel.gameObject.SetActive(false);	
	}

	public void ShowGameClearLabel()
	{
		GameClearLabel.gameObject.SetActive(true);	
	}
}