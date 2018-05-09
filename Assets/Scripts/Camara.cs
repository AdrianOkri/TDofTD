using UnityEngine;
using System.Collections;

public class Camara : MonoBehaviour {

	public GameObject m_objetivo;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(m_objetivo.transform);
	}
}
