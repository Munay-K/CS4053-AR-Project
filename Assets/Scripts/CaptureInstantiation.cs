using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class ARObjectSelectionHandler : MonoBehaviour
{
    public ARPlacementInteractable arPlacementInteractable;

    void OnEnable()
    {
        // Subscribe to the object placement event
        arPlacementInteractable.objectPlaced.AddListener(OnObjectPlaced);
    }

    void OnDisable()
    {
        // Unsubscribe to avoid memory leaks
        arPlacementInteractable.objectPlaced.RemoveListener(OnObjectPlaced);
    }

    // This is called when an object is placed
    void OnObjectPlaced(ARObjectPlacementEventArgs args)
    {
        GameObject placedObject = args.placementObject;
        // Add an event listener to the placed object
        placedObject.AddComponent<TapSelectionHandler>();
    }
}
