using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
	public static void SavePlayer(Player p)
	{
		BinaryFormatter formater = new BinaryFormatter();					// Création d'un convertisseur binaire
		string path = Application.persistentDataPath + "/Player.save";		// Définition du chemin de sauvergarde
		FileStream fileStream = new FileStream(path, FileMode.Create);      // Création du pipeline de sauvegarde
		PlayerData playerData = new PlayerData(p);							// Création d'un fichier à sauver
		formater.Serialize(fileStream, playerData);							// Sérialisation
		fileStream.Close();													// Fermeture du process
	}

	public static PlayerData LoadPlayer()
	{
		string path = Application.persistentDataPath + "/Player.save";

		if (File.Exists(path))
		{
			BinaryFormatter formatter = new BinaryFormatter();
			FileStream fileStream = new FileStream(path, FileMode.Open);
			PlayerData playerData = formatter.Deserialize(fileStream) as PlayerData;
			fileStream.Close();
			return playerData;
		}
		else
		{
			Debug.Log("Not Save Exist");
			return null;
		}
	}
}
