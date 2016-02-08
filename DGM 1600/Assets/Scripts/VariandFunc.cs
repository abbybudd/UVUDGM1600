using UnityEngine;
using System.Collections;

public class VariandFunc : MonoBehaviour 
{
	int myInt = 2;

	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		myInt = DivideByTwo (myInt);
		Debug.Log (myInt);
	}

	int DivideByTwo (int number)
	{
		int ret;
		ret = number / 2;
		return ret;
	}
}