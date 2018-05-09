using UnityEngine;
using System.Collections;

public class Luz : MonoBehaviour {

	Light m_miLuz;
	float m_reloj;
	public float m_tiempo = 2.0f;
	// Use this for initialization
	void Start () {
		m_miLuz = gameObject.GetComponent<Light>();
		m_reloj = 0;
	}
	
	// Update is called once per frame
	void Update () {
		m_reloj += Time.deltaTime;
		if(m_reloj >= m_tiempo){
			m_miLuz.enabled = !m_miLuz.enabled;
			m_reloj=0;
		}
	}
}
