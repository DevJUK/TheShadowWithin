using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// new using stuff :)
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public enum States { Unlocked, Locked, Tick, Star };

public class SaveScript : MonoBehaviour
{

	private GameController Controller;

	private void Start()
	{
		Controller = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
	}


	public void SaveGame()
	{
		// does stuff with binrary one assumes :)
		BinaryFormatter BinFormat = new BinaryFormatter();

		// creates a file in the data path /C/users/appdata/......
		FileStream DataFile = File.Create(Application.persistentDataPath + "/gamedata.dat");

		// creates an instance of the game data class...
		GameData Data = new GameData();

		// populating the new instance with the current values in the game
		Data.Lvl1 = Controller.Lvl1;
		Data.Lvl2 = Controller.Lvl2;
		Data.Lvl3 = Controller.Lvl3;
		Data.Lvl4 = Controller.Lvl4;
		Data.Lvl5 = Controller.Lvl5;
		Data.Lvl6 = Controller.Lvl6;
		Data.Lvl7 = Controller.Lvl7;
		Data.Lvl8 = Controller.Lvl8;
		Data.Lvl9 = Controller.Lvl9;
		Data.Lvl10 = Controller.Lvl10;
		Data.Lvl11 = Controller.Lvl11;
		Data.Lvl12 = Controller.Lvl12;
		Data.Lvl13 = Controller.Lvl13;
		Data.Lvl14 = Controller.Lvl14;
		Data.Lvl15 = Controller.Lvl15;
		Data.Lvl16 = Controller.Lvl16;
		Data.Lvl17 = Controller.Lvl17;
		Data.Lvl18 = Controller.Lvl18;
		Data.Lvl19 = Controller.Lvl19;
		Data.Lvl20 = Controller.Lvl20;
		Data.Lvl21 = Controller.Lvl21;
		Data.Lvl22 = Controller.Lvl22;
		Data.Lvl23 = Controller.Lvl23;
		Data.Lvl24 = Controller.Lvl24;
		Data.Lvl25 = Controller.Lvl25;
		Data.Lvl26 = Controller.Lvl26;
		Data.Lvl27 = Controller.Lvl27;
		Data.Lvl28 = Controller.Lvl28;
		Data.Lvl29 = Controller.Lvl29;
		Data.Lvl30 = Controller.Lvl30;
		Data.Lvl31 = Controller.Lvl31;
		Data.Lvl32 = Controller.Lvl32;
		Data.Lvl33 = Controller.Lvl33;
		Data.Lvl34 = Controller.Lvl34;
		Data.Lvl35 = Controller.Lvl35;
		Data.Lvl36 = Controller.Lvl36;
		Data.Lvl37 = Controller.Lvl37;
		Data.Lvl38 = Controller.Lvl38;
		Data.Lvl39 = Controller.Lvl39;
		Data.Lvl40 = Controller.Lvl40;
		Data.Lvl41 = Controller.Lvl41;
		Data.Lvl42 = Controller.Lvl42;

		// Converts to binrary, using the data from the data thingy in a data file
		BinFormat.Serialize(DataFile, Data);

		// Closes the data file
		DataFile.Close();
	}


	public void LoadGame()
	{
		// checks to see if the file exsists, duh...
		if (File.Exists(Application.persistentDataPath + "/gamedata.dat"))
		{
			BinaryFormatter BinFormat = new BinaryFormatter();

			// Makes a local file with the file in the location and opens it :)
			FileStream DataFile = File.Open(Application.persistentDataPath + "/gamedata.dat", FileMode.Open);

			// converts the file to readable thingys :) ( "unbinraryfys" the file )
			GameData Data = (GameData)BinFormat.Deserialize(DataFile);

			// Closes the file
			DataFile.Close();




			// Sets the values to the values that were in the file
			Controller.Lvl1 = Data.Lvl1;
			Controller.Lvl2 = Data.Lvl2;
			Controller.Lvl3 = Data.Lvl3;
			Controller.Lvl4 = Data.Lvl4;
			Controller.Lvl5 = Data.Lvl5;
			Controller.Lvl6 = Data.Lvl6;
			Controller.Lvl7 = Data.Lvl7;
			Controller.Lvl8 = Data.Lvl8;
			Controller.Lvl9 = Data.Lvl9;
			Controller.Lvl10 = Data.Lvl10;
			Controller.Lvl11 = Data.Lvl11;
			Controller.Lvl12 = Data.Lvl12;
			Controller.Lvl13 = Data.Lvl13;
			Controller.Lvl14 = Data.Lvl14;
			Controller.Lvl15 = Data.Lvl15;
			Controller.Lvl16 = Data.Lvl16;
			Controller.Lvl17 = Data.Lvl17;
			Controller.Lvl18 = Data.Lvl18;
			Controller.Lvl19 = Data.Lvl19;
			Controller.Lvl20 = Data.Lvl20;
			Controller.Lvl21 = Data.Lvl21;
			Controller.Lvl22 = Data.Lvl22;
			Controller.Lvl23 = Data.Lvl23;
			Controller.Lvl24 = Data.Lvl24;
			Controller.Lvl25 = Data.Lvl25;
			Controller.Lvl26 = Data.Lvl26;
			Controller.Lvl27 = Data.Lvl27;
			Controller.Lvl28 = Data.Lvl28;
			Controller.Lvl29 = Data.Lvl29;
			Controller.Lvl30 = Data.Lvl30;
			Controller.Lvl31 = Data.Lvl31;
			Controller.Lvl32 = Data.Lvl32;
			Controller.Lvl33 = Data.Lvl33;
			Controller.Lvl34 = Data.Lvl34;
			Controller.Lvl35 = Data.Lvl35;
			Controller.Lvl36 = Data.Lvl36;
			Controller.Lvl37 = Data.Lvl37;
			Controller.Lvl38 = Data.Lvl38;
			Controller.Lvl39 = Data.Lvl39;
			Controller.Lvl40 = Data.Lvl40;
			Controller.Lvl41 = Data.Lvl41;
			Controller.Lvl42 = Data.Lvl42;

		}
		
	}


}

// holds things we wanna save :)
[Serializable]
class GameData
{
	public States Lvl1;
	public States Lvl2;
	public States Lvl3;
	public States Lvl4;
	public States Lvl5;
	public States Lvl6;
	public States Lvl7;
	public States Lvl8;
	public States Lvl9;
	public States Lvl10;
	public States Lvl11;
	public States Lvl12;
	public States Lvl13;
	public States Lvl14;
	public States Lvl15;
	public States Lvl16;
	public States Lvl17;
	public States Lvl18;
	public States Lvl19;
	public States Lvl20;
	public States Lvl21;
	public States Lvl22;
	public States Lvl23;
	public States Lvl24;
	public States Lvl25;
	public States Lvl26;
	public States Lvl27;
	public States Lvl28;
	public States Lvl29;
	public States Lvl30;
	public States Lvl31;
	public States Lvl32;
	public States Lvl33;
	public States Lvl34;
	public States Lvl35;
	public States Lvl36;
	public States Lvl37;
	public States Lvl38;
	public States Lvl39;
	public States Lvl40;
	public States Lvl41;
	public States Lvl42;
}