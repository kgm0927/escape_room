using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    // �巡�װ� �� �� �̵��Ǵ� �������� ��� static ����
    // static���� �����ϴ� ������ Drop �̺�Ʈ�� ���� ���� ��ũ��Ʈ����
    // �����ϱ� �����̴�.
    //
    public static GameObject beingDraggedIcon;
    public Slot []slot;

    void Start()
    {
        Slot[] slots = GameObject.FindObjectsOfType<Slot>();
    }


    // ������ �ƴ� �ٸ� ������Ʈ�� Icon�� ����� ��� ���󺹱��� ��ġ �����

    Vector3 startPosition;


    // Drag�� UI ���̾ ������������ ���̱� ������
    // Icon �巡�� �� ������ �θ� RactTransform ����
    [SerializeField] Transform onDragParent;




    // ������ �ƴ� �ٸ� ������Ʈ�� Icon�� ����� ��� ������ �θ� �����
    [HideInInspector] public Transform startParent;




  // �������̽� IBeginDragHandler�� ��ӹ޾��� �� �����ؾ� �ϴ� �ݹ��Լ�
void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {

        // �巡�װ� ���۵� �� ��� Icon�� ���� ������Ʈ�� static ������ �Ҵ�.
        beingDraggedIcon = gameObject;

        // ����� �����ǰ� �θ� Ʈ�������� ����� �д�.
        startPosition = transform.position;
        startParent= transform.parent;


        // Drop�̺�Ʈ�� ���������� �����ϱ� ���� Icon RectTransform�� ����
        GetComponent<CanvasGroup>().blocksRaycasts = false;



        // Drop �̺�Ʈ�� ���������� �����ϱ� ���� Icon RectTransform�� ����

        transform.SetParent(onDragParent);
        
    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        beingDraggedIcon = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;


        if(transform.parent == onDragParent)
        {
            transform.position = startPosition;
            transform.SetParent (startParent);
        }

    }
}