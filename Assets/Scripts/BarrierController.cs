using System.Collections;
using UnityEngine;

public class BarrierController : MonoBehaviour 
{
	public UIController2 UIController;

	private void OnTriggerEnter (Collider hit)
	{
		if (hit.CompareTag ("Player")) 
		{
			hit.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;

			UIController.ShowGameOverLabel();
		}
	}
}