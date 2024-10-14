using UnityEngine;
using UnityEngine.EventSystems;

public class TapSelectionHandler : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        // Logic to run when the object is selected
        Debug.Log($"{gameObject.name} selected!");
        // Here you can call your function
        ExecuteOnObjectSelection();
    }

    void ExecuteOnObjectSelection()
    {
        // Add your custom functionality here
        Debug.Log("Custom function executed on object selection!");
    }
}
