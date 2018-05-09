using UnityEngine;
using System.Collections;

public class ControlAnimaciones : MonoBehaviour {

	Animator m_animador;

	public AudioClip m_miSonido;
	public AudioSource m_miOrigen;

	Vector2 m_inicioToque;
	// Use this for initialization
	void Start () {
		m_animador = gameObject.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if( Input.GetKeyDown(KeyCode.Alpha1)){
			m_animador.SetInteger("Direccion",1);
			m_miOrigen.PlayOneShot(m_miSonido);
		}
		if( Input.GetKeyDown(KeyCode.Alpha2)){
			m_animador.SetInteger("Direccion",2);
		}
		if( Input.touchCount > 0 ){
			if( Input.touches[0].phase == TouchPhase.Began){
				m_inicioToque = Input.touches[0].position;
			}else{
				if( Input.touches[0].phase == TouchPhase.Ended){
					Vector2 dif = Input.touches[0].position-m_inicioToque;
					if(Mathf.Abs(dif.x) > Mathf.Abs(dif.y)){
						if(dif.x<0) // Moviento izquierda.
						{}
						else // moviento derecha}
						{}
					}else{
						if(dif.y<0) // Moviento arriba.
						{}
						else // moviento abajo}
						{}			
					}
				}
			}
		}
	}
}
