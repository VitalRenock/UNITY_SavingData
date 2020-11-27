using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
	public int _life;
	public int _level;
	public float[] position;

	public PlayerData(Player p)
	{
		_life = p._life;
		_level = p._level;

		position = new float[3];
		position[0] = p.transform.position.x;
		position[1] = p.transform.position.y;
		position[2] = p.transform.position.z;
	}
}
