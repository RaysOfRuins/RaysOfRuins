using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "QuestKill", menuName = "ScriptableObjects/QuestAction/QuestKill", order = 1)]
[System.Serializable]
public class QuestKill : QuestAction
{
    [SerializeField]
    Faction _faction = new();

    [SerializeField]
    private string _enemyType;

    [SerializeField]
    private int _numberToKill;

    [SerializeField]
    private int _killCount;

    //call when the QuestKill is the current QuestAction to configure it
    public override bool Configure(GameObjectsList objectsToActivateAtStart)
    {
        _killCount = 0;
        for (int i = 0; i < objectsToActivateAtStart.gameObjects.Count; i++)
        {
            objectsToActivateAtStart.gameObjects[i].SetActive(true);
        }
        return false;
    }

    //call when the QuestKill ended
    public override void OnEnd(GameObjectsList objectsToDesactivateAtTheEnd) { }

    //return the text for the objectives
    public override string GetObjectivesText()
    {
        return "- " + LanguageManager.instance.GetText("QuestKill") + " " + _faction + "   " + _killCount + "/" + _numberToKill + "\n";
    }

    //check if the pnj killed is from the good faction to increment the count
    private bool CheckKill(Faction faction, string enemyType)
    {
        if(faction == _faction && enemyType == _enemyType)
        {
            _killCount++;
            return true;
        }
        return false;
    }

    //return if the QuestKill is finished
    public bool IsFinished(Faction faction, string enemyType, out bool hasContributed)
    {
        if(CheckKill(faction, enemyType))
            hasContributed = true;
        else
            hasContributed = false;

        if (_killCount < _numberToKill)
        {
            return false;
        }
        return true;
    }

    public bool TryFillKills(ref List<string> kills)
    {
        bool foundOne = false;

        for (int i = 0; i < kills.Count; i++)
        {
            if (kills[i] == _enemyType)
            {
                _killCount++;
                kills.RemoveAt(i);
                i--;
                foundOne = true;
            }
        }

        return foundOne;
    }
}