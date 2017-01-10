using UnityEngine;
using System.Collections;

public class ControlGame : MonoBehaviour {

	public void ForceQuit(){
		Application.Quit();
	}
	public void ForceStart(string name){
		Application.LoadLevel(name);
	}
}
