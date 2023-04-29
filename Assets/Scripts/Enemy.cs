using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Enemy", menuName ="Normal Enemy")]
public class Enemy : ScriptableObject
{
    public new string name;
    public string attackName;

    public Sprite enemyArt;

    public int healthStat;
    public int attackStat;

}
