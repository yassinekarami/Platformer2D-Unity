﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public GameObject hero;

    Vector3 offset;
	// Use this for initialization
	void Start () {

        offset = transform.position - hero.transform.position;

       
	}
	
	// Update is called once per frame
	void Update () {

        transform.position = offset + hero.transform.position;

    }
}
