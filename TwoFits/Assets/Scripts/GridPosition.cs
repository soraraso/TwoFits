using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridPosition : MonoBehaviour {

	private int m_x;
	private int m_y;

	public GridPosition()
	{
		DebugManager.Log("GridPositionコンストラクタ");
		m_x = m_y = 0;
	}

	public GridPosition(int x, int y)
	{
		m_x = x; m_y = y;
	}

	public int x
	{
		get{return m_x;}
		set{m_x = value;}
	}

	public int y
	{
		get{return m_y;}
		set{m_y = value;}
	}

	public static Vector3 GetVector3()
	{
		Vector3 ans = Vector3.zero;
		return ans;
	}
}
