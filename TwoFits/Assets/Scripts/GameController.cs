using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

	int stageID;
	Stage m_stage;

	void Awake()
	{
		stageID = 1;
	}

	void Start()
	{
		m_stage = new Stage (stageID);
	}
}
