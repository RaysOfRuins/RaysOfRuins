using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Item", order = 1)]
public class Item : ScriptableObject
{
    [SerializeField]
    protected int _weight;

    [SerializeField]
    protected bool _isStackable;

    [SerializeField]
    protected int _maxStack;

    [SerializeField]
    protected Image _itemSprite;

    public bool IsStackable {  get { return _isStackable; } }
    public int MaxStack { get { return _maxStack; } }
    public Image ItemSprite {  get { return _itemSprite; } }
}
