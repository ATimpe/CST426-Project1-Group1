using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModel : GameElement
{
    // GameModel keeps the object data. Add variables for the game to keep track of.
    public int gold;                   // money to spend to buy more pieces
    public int timeRemaining;          // the amount of time left in a level
    public string currentPiece;        // what the current type of road you currently have selected is
    public int rotation;               // what rotation is the piece at
    public Waypoint waypoint;          // Waypoint of the object
    public int straightPieces;         // amount of straight pieces remaining
    public int turnPieces;             // amount of turn pieces remaining
    public int fourPieces;             // amount of 4 way intersection pieces remaining
    public int roundPieces;            // amount of roundabout pieces remaining
}