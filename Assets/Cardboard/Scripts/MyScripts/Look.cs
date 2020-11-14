using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class Look : MonoBehaviour {

	public Renderer skybox;
	public Material sky1;
	public Material sky2;
	public Material sky3;
	public Material sky4;
	private int currentSky = 0;
	// Use this for initialization
	void Start () {
	
	}

	public void stare()
	{
		switch (currentSky) 
		{
		case 0:
			skybox.material = sky2;
			currentSky++;
			break;

		case 1:
			skybox.material = sky3;
			currentSky++;
			break;

		case 2:
			skybox.material = sky3;
			currentSky++;
			break;

		case 3:
			skybox.material = sky4;
			currentSky++;
			break;

		}
	}
	// Update is called once per frame
	void Update () {
	
	}
}
