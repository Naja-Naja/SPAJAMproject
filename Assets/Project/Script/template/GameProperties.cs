using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum GameVisualMode
{
    spanyan,
    ant
}
public enum GameMode
{
    play,
    result
}
[CreateAssetMenu(fileName = "GameProperties", menuName = "GameProperties")]
public class GameProperties : ScriptableObject
{
    public int score;
    public int calorie;
    public GameVisualMode visualmode;
    public GameMode mode;
    public int HP;
}
