using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public int _life;
	public int _level;

	private void Update()
	{
		transform.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * Time.deltaTime;
	}

	public void Save()
	{
		SaveSystem.SavePlayer(this);
	}

	public void Load()
	{
		PlayerData playerData = SaveSystem.LoadPlayer();
		_life = playerData._life;
		_level = playerData._level;
		transform.position = new Vector3(playerData.position[0], playerData.position[1], playerData.position[2]);
	}
}
