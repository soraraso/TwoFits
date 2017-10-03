using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugManager : MonoBehaviour {

	public static void Log(string str)
	{
#if UNITY_EDITOR
		Debug.Log(str);
#endif
	}
}
