using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum BlockType
{
	Empty,
	Normal,
	Goal,
}

public class Block : MonoBehaviour {

	private BlockType m_blockType;
	private GridPosition m_gridPos;

	public BlockType blockType
	{
		get{ return m_blockType;}
		set{ m_blockType = value;}
	}

	public GridPosition gridPos
	{
		get{ return m_gridPos;}
		set{ m_gridPos = value;}
	}

	public Block() 
	{
		DebugManager.Log("Blockクラスのコンストラクタ");
	}
}
