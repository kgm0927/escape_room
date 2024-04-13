using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IconDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{


    // 드래그가 될 대 이동되는 아이콘을 담는 static 변수
    // static으로 선언하는 이유는 Drop 이벤트를 가진 슬록 스크립트에서
    // 접근하기 위함이다.
    //
    public static GameObject beingDraggedIcon;
    public Slot []slot;

    void Start()
    {
        Slot[] slots = GameObject.FindObjectsOfType<Slot>();
    }


    // 슬록이 아닌 다른 오브젝트에 Icon을 드랍할 경우 원상복귀할 위치 백업용

    Vector3 startPosition;


    // Drag중 UI 레이어에 비정상적으로 보이기 때문에
    // Icon 드래그 중 변경할 부모 RactTransform 변수
    [SerializeField] Transform onDragParent;




    // 슬록이 아닌 다른 오브젝트에 Icon을 드랍할 경우 원복할 부모 백업용
    [HideInInspector] public Transform startParent;




  // 인터페이스 IBeginDragHandler를 상속받았을 때 구현해야 하는 콜백함수
void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {

        // 드래그가 시작될 때 대상 Icon의 게임 오브젝트를 static 변수에 할당.
        beingDraggedIcon = gameObject;

        // 백업용 포지션과 부모 트랜스폼을 백업해 둔다.
        startPosition = transform.position;
        startParent= transform.parent;


        // Drop이벤트를 정상적으로 감지하기 위해 Icon RectTransform을 무시
        GetComponent<CanvasGroup>().blocksRaycasts = false;



        // Drop 이벤트를 정상적으로 감지하기 위해 Icon RectTransform을 무시

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