using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
	public float MoveSpeed;
	public float JumpHeight;
	public Rigidbody2D[] RBs;

	public States Lvl1 = States.Unlocked;
	public States Lvl2 = States.Locked;
	public States Lvl3 = States.Locked;
	public States Lvl4 = States.Locked;
	public States Lvl5 = States.Locked;
	public States Lvl6 = States.Locked;
	public States Lvl7 = States.Locked;
	public States Lvl8 = States.Locked;
	public States Lvl9 = States.Locked;
	public States Lvl10 = States.Locked;
	public States Lvl11 = States.Locked;
	public States Lvl12 = States.Locked;
	public States Lvl13 = States.Locked;
	public States Lvl14 = States.Locked;
	public States Lvl15 = States.Locked;
	public States Lvl16 = States.Locked;
	public States Lvl17 = States.Locked;
	public States Lvl18 = States.Locked;
	public States Lvl19 = States.Locked;
	public States Lvl20 = States.Locked;
	public States Lvl21 = States.Locked;
	public States Lvl22 = States.Locked;
	public States Lvl23 = States.Locked;
	public States Lvl24 = States.Locked;
	public States Lvl25 = States.Locked;
	public States Lvl26 = States.Locked;
	public States Lvl27 = States.Locked;
	public States Lvl28 = States.Locked;
	public States Lvl29 = States.Locked;
	public States Lvl30 = States.Locked;
	public States Lvl31 = States.Locked;
	public States Lvl32 = States.Locked;
	public States Lvl33 = States.Locked;
	public States Lvl34 = States.Locked;
	public States Lvl35 = States.Locked;
	public States Lvl36 = States.Locked;
	public States Lvl37 = States.Locked;
	public States Lvl38 = States.Locked;
	public States Lvl39 = States.Locked;
	public States Lvl40 = States.Locked;
	public States Lvl41 = States.Locked;
	public States Lvl42 = States.Locked;

	private void Awake()
	{
		DontDestroyOnLoad(this);
	}
}
