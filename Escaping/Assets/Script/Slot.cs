using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{// 드랍 이벤트 감지를 위한 상속


    GameObject Icon()
    {

        if (transform.childCount>0)
            return transform.GetChild(0).gameObject;
        else 
            return null;
        
    }
    // IDDropHandler 인터페이스 상속시 구현해야 하는 콜백 함수.

    // 이 스크립트가 컴포넌트로 추가 된 게임 오브젝트 RectTransform내에




    // 포인터 드랍이 발생하면 실행되는 콜백함수.
    // Start is called before the first frame update
    void IDropHandler.OnDrop(PointerEventData eventData)
    {
        if (Icon()==null)
        {
            IconDrag.beingDraggedIcon.transform.SetParent(transform);
            IconDrag.beingDraggedIcon.transform.position = transform.position;
        }
    }
}
