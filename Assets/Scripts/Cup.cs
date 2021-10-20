
using UnityEngine;

public class Cup : MonoBehaviour{

	public int score;

	void OnCollisionEnter2D(Collision2D col){
		
		if(col.gameObject.tag == "uno"){
			Puntos.ValPuntos += score;
			Destroy(gameObject);
		}
	}
}
