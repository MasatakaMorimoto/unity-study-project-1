﻿using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour {

	void Start () {
        string str = "happy ";
        int num = 123;

        string message = str + num.ToString();
        Debug.Log(message);
	}
	
	/*void Update (){
	
	}*/
}
