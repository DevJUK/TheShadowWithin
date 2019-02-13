using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public enum Buttons
{
	LvlSelect,
	Menu,
	Settings,
	Credits,
	Acheivements,
	Lvl1,
	Lvl2,
	Lvl3,
	Lvl4,
	Lvl5,
	Lvl6,
	Lvl7,
	Lvl8,
	Lvl9,
	Lvl10,
	Lvl11,
	Lvl12,
	Lvl13,
	Lvl14,
	Lvl15,
	Lvl16,
	Lvl17,
	Lvl18,
	Lvl19,
	Lvl20,
	Lvl21,
	Lvl22,
	Lvl23,
	Lvl24,
	Lvl25,
	Lvl26,
	Lvl27,
	Lvl28,
	Lvl29,
	Lvl30,
	Lvl31,
	Lvl32,
	Lvl33,
	Lvl34,
	Lvl35,
	Lvl36,
	Lvl37,
	Lvl38,
	Lvl39,
	Lvl40,
	Lvl41,
	Lvl42,
	Info,		// only at the bottom cause I cba going through and changing all the buttons on the level select to the option 1 below what it'll be on
};

public class ButtonController : MonoBehaviour
{
	public Buttons Button;

	public void ChangeScene()
	{
		switch (Button)
		{
			case Buttons.LvlSelect:
				SceneManager.LoadSceneAsync("LevelSelect");
				break;
			case Buttons.Menu:
				break;
			case Buttons.Settings:
				break;
			case Buttons.Credits:
				break;
			case Buttons.Acheivements:
				break;
			case Buttons.Lvl1:
				SceneManager.LoadSceneAsync("Lvl1");
				break;
			case Buttons.Lvl2:
				SceneManager.LoadSceneAsync("Lvl2");
				break;
			case Buttons.Lvl3:
				SceneManager.LoadSceneAsync("Lvl3");
				break;
			case Buttons.Lvl4:
				SceneManager.LoadSceneAsync("Lvl4");
				break;
			case Buttons.Lvl5:
				SceneManager.LoadSceneAsync("Lvl5");
				break;
			case Buttons.Lvl6:
				SceneManager.LoadSceneAsync("Lvl6");
				break;
			case Buttons.Lvl7:
				SceneManager.LoadSceneAsync("Lvl7");
				break;
			case Buttons.Lvl8:
				SceneManager.LoadSceneAsync("Lvl8");
				break;
			case Buttons.Lvl9:
				SceneManager.LoadSceneAsync("Lvl9");
				break;
			case Buttons.Lvl10:
				SceneManager.LoadSceneAsync("Lvl10");
				break;
			case Buttons.Lvl11:
				SceneManager.LoadSceneAsync("Lvl11");
				break;
			case Buttons.Lvl12:
				SceneManager.LoadSceneAsync("Lvl12");
				break;
			case Buttons.Lvl13:
				SceneManager.LoadSceneAsync("Lvl13");
				break;
			case Buttons.Lvl14:
				SceneManager.LoadSceneAsync("Lvl14");
				break;
			case Buttons.Lvl15:
				SceneManager.LoadSceneAsync("Lvl15");
				break;
			case Buttons.Lvl16:
				SceneManager.LoadSceneAsync("Lvl16");
				break;
			case Buttons.Lvl17:
				break;
			case Buttons.Lvl18:
				break;
			case Buttons.Lvl19:
				break;
			case Buttons.Lvl20:
				break;
			case Buttons.Lvl21:
				break;
			case Buttons.Lvl22:
				break;
			case Buttons.Lvl23:
				break;
			case Buttons.Lvl24:
				break;
			case Buttons.Lvl25:
				break;
			case Buttons.Lvl26:
				break;
			case Buttons.Lvl27:
				break;
			case Buttons.Lvl28:
				break;
			case Buttons.Lvl29:
				break;
			case Buttons.Lvl30:
				break;
			case Buttons.Lvl31:
				break;
			case Buttons.Lvl32:
				break;
			case Buttons.Lvl33:
				break;
			case Buttons.Lvl34:
				break;
			case Buttons.Lvl35:
				break;
			case Buttons.Lvl36:
				break;
			case Buttons.Lvl37:
				break;
			case Buttons.Lvl38:
				break;
			case Buttons.Lvl39:
				break;
			case Buttons.Lvl40:
				break;
			case Buttons.Lvl41:
				break;
			case Buttons.Lvl42:
				break;
			case Buttons.Info:
				break;
			default:
				break;
		}
	}
}
