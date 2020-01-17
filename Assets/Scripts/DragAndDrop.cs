using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class DragAndDrop : MonoBehaviour, IDragHandler, IEndDragHandler, IBeginDragHandler, IDropHandler
{
    [SerializeField] private GameObject _draggedPref;
    private GameObject _draggedObject;
    private bool    _isDrraggable = false;
    private Vector3 _startPosition;

    [SerializeField] private gameManager _gameManager;
    // Start is called before the first frame update
    void Start()
    {
        _startPosition = transform.position;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        if (_draggedPref)
        {
            _draggedObject = Instantiate(_draggedPref, transform);
            // itemBeingDragged = gameObject;
        }
    }
    public void OnDrag(PointerEventData eventData)
    {
        _draggedObject.transform.position = Input.mousePosition;
    }

    // Update is called once per frame

    public void OnEndDrag(PointerEventData eventData)
    {
        _draggedObject.transform.localPosition = Vector3.zero;
    }

    public void OnDrop(PointerEventData eventData)
    {
        RaycastHit hit = new RaycastHit();
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RectTransform panel = transform as RectTransform;
        if (Physics.Raycast(ray, out hit, 1000) && !RectTransformUtility.RectangleContainsScreenPoint(panel, Input.mousePosition))
        {
            _draggedObject.transform.position = hit.point;
        }

    }
}