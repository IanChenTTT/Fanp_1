using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class GameData 
{
    public Vector3 playerPosition;

    //the values defind in this constructor will be the default values
    //the game starts with when there's no data to load
    public GameData(){
        this.playerPosition = Vector3.zero;
    }
}
