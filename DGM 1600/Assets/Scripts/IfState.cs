using UnityEngine;
using System.Collections;

public class IfState : MonoBehaviour
{
	public float hotcocoaTemperature = 85.0f;
	public float hotLimitTemperature = 70.0f;
	public float coldLimitTemperature = 40.0f;


	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.Space))
			TemperatureTest();

		hotcocoaTemperature -= Time.deltaTime * 5f;
	}


	void TemperatureTest ()
	{
		if(hotcocoaTemperature > hotLimitTemperature)
		{
			Debug.Log("Hot Cocoa is too hot.");
		}
		else if(hotcocoaTemperature < coldLimitTemperature)
		{
			Debug.Log("Hot Cocoa is too cold.");
		}
		else
		{
			Debug.Log("Hot Cocoa is just right.");
		}
	}
}