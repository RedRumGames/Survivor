using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using System;

public class MakeUIElement : MonoBehaviour, IPointerClickHandler {
    #region IpointerClickHandler implementation
    [SerializeField]
    GameObject UIElement;
    public void OnPointerClick(PointerEventData eventData)
    {
        Vector3 screenPosition = new Vector3(eventData.position.x, eventData.position.y, eventData.pointerPressRaycast.distance);
        Vector3 instantiatePosition = eventData.pressEventCamera.ScreenToWorldPoint(screenPosition);
        GameObject clone = (GameObject)Instantiate(UIElement, instantiatePosition, eventData.pressEventCamera.transform.rotation);
        clone.transform.SetParent(transform);
    }
    #endregion
}
