using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;

public class Stage : MonoBehaviour {

	private int m_id = Constants.ROW;
	private Block[,] m_blocks = new Block[Constants.ROW, Constants.COLUMN];

	public int id
	{
		get{return m_id;}
		set{m_id = value;}
	}

	public Block[,] blocks 
	{
		get{ return m_blocks; }
		set{ blocks = value;}
	}

	public Stage() {}
	public Stage(int stageID)
	{
		m_id = stageID;
		m_blocks = CSVManager.GetStageDataWithStageID (stageID);

		DebugManager.Log ("stageID = " + stageID + "\n");
	}

}
