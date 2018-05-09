using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class rotacion : MonoBehaviour {
	void Awake(){
		Debug.Log(">>> Hola mundo");
	}
	// Use this for initialization
	void Start () {
		Debug.Log(">>> Hola mundo 2");
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation *= Quaternion.Euler(0,90.0f* Time.deltaTime,0)  ;
		if( Input.anyKeyDown){
			SceneManager.LoadScene("MainMenu");
		}
	}
}
