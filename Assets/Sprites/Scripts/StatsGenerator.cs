using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
///  A <see langword="static"/> class with methods (functions) for initialising or randomising the stats class.
///  
/// TODO:
///     Initialise a stats instance with generated starting stats
///     Handle the assignment of extra points or xp into an existing stats of a character
///         - this is expected to be used by NPCs leveling up to match the player.
/// </summary>
public static class StatsGenerator
{
    public static void InitialStats(Stats stats)
    {
        //Random.Range.....It will choose between two numbers by your choise randolmy
        /*stats.level = 1; ,/ stats.luck stats.rhythm,/ stats.style stats.xp = 0;....all of these are stats for the player when the game starts*/

        stats.level = 1;
        stats.luck = Random.Range(1,7);
        stats.rhythm = Random.Range(1,8);
        stats.style = Random.Range(5,10);
        stats.xp = 0;
        
    }

    public static void AssignUnusedPoints(Stats stats, int points)
    {

    }
}
