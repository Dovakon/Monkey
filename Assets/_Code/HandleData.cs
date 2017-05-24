using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleData : MonoBehaviour {


    public Transform player;


    private List<State> state;
    private State currentState;
	
	void Start () {

        state = new List<State>();
        //currentState = new State();
        StartCoroutine(WriteData());
    }
	
	
    
    IEnumerator WriteData()
    {
        while (true)
        {

            //currentState.position = new Vector2(player.position.x, player.position.y);
            //currentState.time = Time.time;

            state.Add(new State(player.position, Time.time));
            yield return new WaitForSeconds(0.1f);
        }
    }

    

}

[Serializable]
public class State
{
    public Vector2 position;
    public float time;

    public State(Vector2 pos, float t)
    {
        position = pos;
        time = t;
    }
}