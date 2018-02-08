using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainmenu1: MonoBehaviour {

	public GameObject MainMenu;
	public GameObject settings;
	void Start () {

	}
	public void Scene0()
	{
		SceneManager.LoadScene ("Scene0");
	}
	public void Quit()
	{
		Application.Quit ();

	}
	//public void VolumeControl(float volumeControl)
	//{
	//	GetComponent<AudioSource> ().volume = volumeControl;
	//}
	public void setting()
	{
		MainMenu.SetActive (false);
		settings.SetActive (true);

	}
	public void mainmenu()
	{
		MainMenu.SetActive (true);
		settings.SetActive (false);	
	}
}
