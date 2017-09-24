using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class UIController2: MonoBehaviour 
{
	public Text GameOverLabel;

	public Button yourButton;

	private void Start () 
	{
		GameOverLabel.gameObject.SetActive(false);	
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		yourButton.gameObject.SetActive(false);
	}

	public void ShowGameOverLabel()
	{
		GameOverLabel.gameObject.SetActive(true);	
		yourButton.gameObject.SetActive(true);	
	}

	void TaskOnClick()
	{
		SceneManager.LoadScene (0);
	}
}