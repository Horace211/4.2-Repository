using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPlayerScript : MonoBehaviour {

    static MusicPlayerScript duplicateInstance = null;
    //static bool availablePlayer = false;

	// Use this for initialization
	void Start () {

        //if (availablePlayer == false)
        if (duplicateInstance == null)
        {
           DontDestroyOnLoad(gameObject);
            duplicateInstance = this;
            //availblePlayer = true;
        }
        else
        {
            Destroy(gameObject);
            print("Duplicate Music Player is self destructing!");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
