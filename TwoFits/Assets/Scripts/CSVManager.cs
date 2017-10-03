using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;
using System;

public class CSVManager : MonoBehaviour {

	public static Block[,] GetStageDataWithStageID(int stageID)
	{
		Block[,] blocks = new Block[Constants.ROW, Constants.COLUMN];
		for(int i=0; i < Constants.ROW; ++i)
		{
			for(int j=0; j < Constants.COLUMN; ++j)
			{
				blocks [i, j] = new Block ();
			}
		}

		//テキストファイルの読み込み
		TextAsset _fieldTxt = Resources.Load("CSV/STAGE_CSV/Stage" + stageID,  typeof(TextAsset)) as TextAsset;

		//区切り条件指定
//		char[] _kugiri = {'\r','\n'};//改行区切り、二種類
		char[] _lineBreak = {'\n'};

		//String配列に格納
		string[] _fieldString = _fieldTxt.text.Split(_lineBreak);

		for(int i=0; i < Constants.ROW; ++i)
		{
			string[] _tempLetter = _fieldString[i].Split(',');

			for(int j=0; j < Constants.COLUMN ; ++j)
			{
//				DebugManager.Log ("i = " + i + " j = " + j);
				DebugManager.Log( "blocks["+i+"][" +j+ "] = " + int.Parse( _tempLetter[j]) );
				blocks[i, j].blockType = (BlockType)Enum.ToObject( typeof(BlockType), int.Parse( _tempLetter[j]) );
				blocks [i, j].gridPos = new GridPosition (i, j);
			}
		}

		return blocks;
	}
}
