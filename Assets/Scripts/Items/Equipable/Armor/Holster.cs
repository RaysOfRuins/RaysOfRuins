using UnityEngine;

[CreateAssetMenu(fileName = "Holster", menuName = "ScriptableObjects/Item/Equipable/Armor/Holster", order = 1)]
public class Holster : Armor
{
    [SerializeField]
    private int _hoslterTier;

    public int HolsterTier {  get { return _hoslterTier;} }
}