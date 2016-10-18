﻿using UnityEngine;
using UnityEngine.UI;

class Level1Controller : LevelController
{
    protected override void Start()
    {
        base.Start();

        _score = 1000;
        _lives = 10;

        this._nextLevel = "Level2";
    }
}
