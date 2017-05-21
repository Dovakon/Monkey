using UnityEngine;
using System.Collections;

public class InstaKill : MonoBehaviour {

	public void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            print("Damage taken");
        }
    }
}
