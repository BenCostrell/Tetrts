﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : Scene<TransitionData> {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    internal override void OnEnter(TransitionData data)
    {
        InitializeServices();
        Services.GridManager.GenerateGrid();
    }

    void InitializeServices()
    {
        Services.Main = this;
        Services.GridManager = GetComponentInChildren<GridManager>();
    }
}
