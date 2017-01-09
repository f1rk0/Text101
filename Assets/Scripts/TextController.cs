using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, cell_1, sheets, cell_wrap, mirror, door, mirror_wrapped, mirror_cracked, look_closer, lock_0, cell_mirror, sheets_1, lock_1, freedom};
	private States myState;

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}
	
	// Update is called once per frame
	void Update () {
		print(myState);
		if (myState == States.cell){
			state_cell();
		} else if (myState == States.sheets){
			state_sheets();
		} else if (myState == States.mirror){
			state_mirror();
		} else if (myState == States.door){
			state_door();
		} else if (myState == States.look_closer){
			state_look_closer();
		} else if (myState == States.cell_1){
			state_cell_1();
		}
	}
	
	void state_cell (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed, a mirror on the wall, and the door " +
					"is locked.\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets;
		} else if (Input.GetKeyDown(KeyCode.M)){
			myState = States.mirror;
		} else if (Input.GetKeyDown(KeyCode.D)){
			myState = States.door;
		}
	}
	
	void state_mirror (){
		text.text = "You see a bearded man in the reflection. Woah, how long did you " +
					"sleep here to grow such a monstrous beard! Even Santa Claus will " +
					"be jealous if see this! Maybe you could you that mirror later!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		}
	}
		
	void state_door (){
		text.text = "A massive wooden door with tiny ventilation grid on it. " +
					"So small that you can't even push a finger there. And of course there's a lock. " +
					"It's a door for fuck sake!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
				myState = States.cell;
		}
	}
	
	void state_sheets (){
		text.text = "You can't believe you sleep in these things. Surely it's " +
					"time somebody changed them. The pleasures of prison life " +
					"I guess! \n\n" +
					"Press R to Return to roaming your cell or L to look closer";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell;
		} else if (Input.GetKeyDown(KeyCode.L)){
			myState = States.look_closer;
		}
	}
	
	void state_look_closer (){
		text.text = "You begin to inspect every detail. You notice that mattress " +
					"is harder at one place. You try to tear mattress but you are too weak now. " +
					"There must be another way!\n\n" +
					"Press R to Return to roaming your cell";
		if (Input.GetKeyDown(KeyCode.R)){
			myState = States.cell_1;
		}
	}
	
	void state_cell_1 (){
		text.text = "You are in a prison cell, and you want to escape. There are " +
					"some dirty sheets on the bed with something inside, a mirror on the wall, " +
					"and the door is locked. Maybe mirror can give some ideas?\n\n" +
					"Press S to view Sheets, M to view Mirror or D to view Door";
		if (Input.GetKeyDown(KeyCode.S)){
			myState = States.sheets;
		} else if (Input.GetKeyDown(KeyCode.M)){
			//myState = States.mirror_1;
		} else if (Input.GetKeyDown(KeyCode.D)){
			myState = States.door;
		}
	}

}
