using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// new using stuff :)
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


public class SaveScript : MonoBehaviour
{

	private GameController ControllerScript;
	private TimerScript TimeScript;

	private void Start()
	{
		ControllerScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
		TimeScript = GameObject.FindGameObjectWithTag("GameController").GetComponent<TimerScript>();
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
		//Data.Score = ControllerScript.ReactorTotalPoints;
		//Data.Energy = ControllerScript.Energy;
		//Data.ReactorPoints = ControllerScript.EnergyPoints;
		//Data.ReactorHealth = ControllerScript.ReactorHealth;
		//Data.ReactorStability = ControllerScript.ReactorStability;
		//Data.ReactorWaterLevel = ControllerScript.ReactorWater;
		//Data.ReactorFuelLevel = ControllerScript.ReactorPower;
		//Data.WaterBought = ControllerScript.WaterPower;
		//Data.FuelBought = ControllerScript.ReactorFuel;
		//Data.EnergyMultiplier = ControllerScript.Multiplier;
		//Data.AutoWater = ControllerScript.AutoWater;
		//Data.AutoFuel = ControllerScript.AutoFuel;
		//Data.AutoEnergy = ControllerScript.AutoMultiply;
		//Data.Time = TimeScript.Timer;
		//Data.ThemeBought = ControllerScript.ThemeBought;

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

			//ControllerScript.ReactorTotalPoints = Data.Score;
			//ControllerScript.Energy = Data.Energy;
			//ControllerScript.EnergyPoints = Data.ReactorPoints;
			//ControllerScript.ReactorHealth = Data.ReactorHealth;
			//ControllerScript.ReactorStability = Data.ReactorStability;
			//ControllerScript.ReactorWater = Data.ReactorWaterLevel;
			//ControllerScript.ReactorPower = Data.ReactorFuelLevel;
			//ControllerScript.WaterPower = Data.WaterBought;
			//ControllerScript.ReactorFuel = Data.FuelBought;
			//ControllerScript.Multiplier = Data.EnergyMultiplier;
			//ControllerScript.AutoWater = Mathf.RoundToInt(Data.AutoWater);
			//ControllerScript.AutoFuel = Mathf.RoundToInt(Data.AutoFuel);
			//ControllerScript.AutoMultiply = Mathf.RoundToInt(Data.AutoEnergy);
			//TimeScript.Timer = Data.Time;
			//ControllerScript.ThemeBought = Data.ThemeBought;

		}

		// Loads the level scene again
		ControllerScript.ChangeLevelState(GameStates.Level);
	}


}

// holds things we wanna save :)
[Serializable]
class GameData
{
	public enum States { Unlocked, Locked, Tick, Star };

	public States Lvl1;
	public States Lvl2;

	//public float Score;
	//public float Energy;
	//public float ReactorPoints;
	//public float ReactorStability;
	//public float ReactorHealth;
	//public float ReactorWaterLevel;
	//public float ReactorFuelLevel;
	//public float WaterBought;
	//public float FuelBought;
	//public float EnergyMultiplier;
	//public float AutoWater;
	//public float AutoFuel;
	//public float AutoEnergy;
	//public float Time;
	//public bool ThemeBought;
}