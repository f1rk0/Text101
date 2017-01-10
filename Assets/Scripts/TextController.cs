using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, cell_1, cell_2, cell_wrap, sheets, sheets_1, sheets_2, sheets_shred, mirror, mirror_1, mirror_2, door, mirror_crack, key_found, look_closer, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
	
		if (Input.GetKey(KeyCode.Escape))		{Application.Quit();}
		print(myState);
		if (myState == States.cell)					{cell();}
		else if (myState == States.sheets)			{sheets();}
		else if (myState == States.mirror)			{mirror();}
		else if (myState == States.door)			{door();}
		else if (myState == States.look_closer)		{look_closer();}
		else if (myState == States.cell_1)			{cell_1();}
		else if (myState == States.mirror_1)		{mirror_1();}
		else if (myState == States.cell_2)			{cell_2();}
		else if (myState == States.sheets_1)		{sheets_1();}
		else if (myState == States.cell_wrap)		{cell_wrap();}
		else if (myState == States.sheets_2)		{sheets_2();}
		else if (myState == States.mirror_2)		{mirror_2();}
		else if (myState == States.mirror_crack)	{mirror_crack();}
		else if (myState == States.sheets_shred)	{sheets_shred();}
		else if (myState == States.key_found)		{key_found();}
		else if (myState == States.freedom)			{freedom();}
	}
	
	#region States description
	void cell (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked.\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.door;}
	}
	
	void mirror (){
		text.text = "You see a bearded man in the reflection. Woah, how long did you " +
					"sleep here to grow such a monstrous beard! Even Santa Claus will " +
					"be jealous if see this! Maybe you could use that mirror later!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
		
	void door (){
		text.text = "A massive wooden door with tiny ventilation grid on it. " +
					"So small that you can't even push a finger there. And of course there's a lock. " +
					"It's a door for fuck sake!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
	}
	
	void sheets (){
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess! \n\n" +
					"Press R to Return to roaming your cell or L to look closer";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell;}
		else if (Input.GetKeyDown(KeyCode.L))	{myState = States.look_closer;}
	}
	
	void look_closer (){
		text.text = "You begin to inspect every detail. You notice that mattress " +
					"is harder at one place. You try to tear mattress but you are too weak now. " +
					"There must be another way!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_1;}
	}
	
	void cell_1 (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed with something inside, a mirror on the wall, " +
					"and the door is locked. Maybe mirror can give some ideas?\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror_1;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.door;}
	}

	void mirror_1 (){
		text.text = "It seems that you can break the mirror. But if you'll do it now " +
					"you'll just hurt yourself and die of constant bleeding. " +
					"Not great idea... Try to find some protection.\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_2;}
	}
	
	void cell_2 (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed with something inside, a mirror to break " +
					"and the door locked. Maybe sheets will help?\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_1;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror_1;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.door;}
	}
	
	void sheets_1 (){
		text.text = "You notice that pillowcase is cleaner than everything else. " +
					"It can fit your needs. Or you can try to continue your search. " +
					"But what will you find on the mirror or at the door? \n\n" +
					"Press R to Return to roaming your cell or P to take pillowcase";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_2;}
		else if (Input.GetKeyDown(KeyCode.P))	{myState = States.cell_wrap;}
	}
	
	void cell_wrap (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed with something inside, a mirror to break " +
					"and the door locked. Do you have everything to break the mirror?\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.sheets_2;}
		else if (Input.GetKeyDown(KeyCode.M))	{myState = States.mirror_2;}
		else if (Input.GetKeyDown(KeyCode.D))	{myState = States.door;}
	}
	
	void sheets_2 (){
		text.text = "There's nothing you can do right now. " +
					"Unless you want to sleep on... that. " +
					"Maybe its better to do something else?\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_wrap;}
	}
	
	void mirror_2 (){
		text.text = "You can wrap your hand with pillowcase and break the mirror " +
					"or you can think about your miserable life. " +
					"What will you choose?\n\n" +
					"Press R to Return to roaming your cell or B to break the mirror";
		if (Input.GetKeyDown(KeyCode.R))		{myState = States.cell_wrap;}
		else if (Input.GetKeyDown(KeyCode.B))	{myState = States.mirror_crack;}
	}
	
	void mirror_crack (){
		text.text = "Your jab was successful and mirror broke into pieces. " +
					"You see one sharp enough to shred mattress. " +
					"Take it and turn to mattress.\n\n" +
					"Press T to take shard.";
		if (Input.GetKeyDown(KeyCode.T))		{myState = States.sheets_shred;} 
	}
	
	void sheets_shred (){
		text.text = "One more move and you will find out what is inside. " +
					"Lets make it!\n\n" +
					"Press S to rip mattress.";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.key_found;} 
	}
	
	void key_found (){
		text.text = "Oh look! That's a key! Who would ever imagine such thing... " +
					"Sarcasm! Try to open the door with it.\n\n" +
					"Press O to open the door.";
		if (Input.GetKeyDown(KeyCode.O))		{myState = States.freedom;} 
	}
	
	void freedom (){
		text.text = "You've made it! Congratulations! " +
					"Want to try one more time?\n\n" +
					"Press S to start again, Esc key to exit.";
		if (Input.GetKeyDown(KeyCode.S))		{myState = States.cell;}
		if (Input.GetKey(KeyCode.Escape))		{Application.Quit();}
	}
	#endregion	
}