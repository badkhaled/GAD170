using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Static class with method (function) to determine the outcome of a dance battle based on the player and NPC that are 
///     dancing off against each other.
///     
/// TODO:
///     Battle needs to use stats and random to determine the winner of the dance off
///       - outcome value to be a float value between 1 and negative 1. 1 being the biggest possible player win over NPC, 
///         through to -1 being the most decimating defeat of the player possible.
/// </summary>
public static class BattleHandler
{
    public static void Battle(BattleEventData data)
    {
        //This needs to be replaced with some actual battle logic, at present 
        // we just award the maximum possible win to the player
        float outcome = Random.Range(-1.0f, 1.0f);

        Debug.Log(outcome);
        Debug.Log(data.npc.level + " npc level");
        Debug.Log(data.npc.luck + " npc luck");
        Debug.Log(data.npc.rhythm + " npc rhythm");
        Debug.Log(data.npc.style + " npc style");
        Debug.Log(data.npc.xp + " npc xp");
        Debug.Log(data.player.luck + " player luck");
        Debug.Log(data.player.rhythm + " player rhythm");
        Debug.Log(data.player.style + " player style");
        Debug.Log(data.player.level + " player level");
        Debug.Log(data.player.xp + " player xp");



        var results = new BattleResultEventData(data.player, data.npc, outcome);

        GameEvents.FinishedBattle(results);
    }
}
