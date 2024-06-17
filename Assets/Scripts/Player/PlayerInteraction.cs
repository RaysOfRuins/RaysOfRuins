using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Windows;

public class PlayerInteraction : MonoBehaviour
{
    public static PlayerInteraction Instance;

    [SerializeField]
    private PlayerInput _playerInput;
    private InputActionMap _actionMapInGame;

    private Inventory _inventory;

    public List<Interactable> interactables = new List<Interactable>();

    private Interactable _closestInteractable;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _actionMapInGame = _playerInput.actions.FindActionMap("InGame");
        _inventory = Inventory.Instance;
    }

    /// <summary>
    /// Select the nearest interactable and highligh it
    /// </summary>
    private void Update()
    {
        for (int i = 0; i < interactables.Count; i++)
        {
            if (interactables[i] != null)
            {
                interactables[i].Highlight(false);
            }
        }
        Interactable interactable = GetNearestInteractable();
        if (interactable != null)//if we find the nearest interactable, highlight it
        {
            _closestInteractable = interactable;
            _closestInteractable.Highlight(true);
        }
        else
        {
            _closestInteractable = null;
        }
    }

    /// <summary>
    /// Caculates and returns the closest container to the player (if there are any)
    /// </summary>
    private Interactable GetNearestInteractable()
    {
        if (interactables.Count < 1 )
        {
            return null;
        }

        Interactable nearestInteractable = interactables[0];
        float nearestInteractableDistance = Vector3.Distance(transform.position, interactables[0].transform.position);

        for (int i = 1; i < interactables.Count; i++)
        {
            if (interactables[i] != null)
            {
                float distance = Vector3.Distance(transform.position, interactables[i].transform.position);
                if (distance < nearestInteractableDistance)
                {
                    nearestInteractable = interactables[i];
                    nearestInteractableDistance = distance;
                }
            }
        }

        return nearestInteractable;
    }

    /// <summary>
    /// Try to open a container, if there are multiple, opens the closest
    /// </summary>
    public void PlayerInteract(InputAction.CallbackContext context)
    {
        if (context.started && _actionMapInGame.enabled)
        {
            if (_inventory.isInventoryOpen) 
            {
                _inventory.OpenFullInventory();
                return;
            }
            GetNearestInteractable();
            if (_closestInteractable != null)//If a container is close, open the inventory and the container
            {
                _closestInteractable.TryToInteract();
            }
        }
    }
}
