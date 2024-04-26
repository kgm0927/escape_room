using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{// ��� �̺�Ʈ ������ ���� ���

  private Stuff stf;

    private void Start()
    {
        stf = null;
    }


    public GameObject Icon()
    {

        if (transform.childCount > 0)
            return 
        transform.GetChild(0).gameObject;
        else
            return null;
        
    }
    // IDDropHandler �������̽� ��ӽ� �����ؾ� �ϴ� �ݹ� �Լ�.

    // �� ��ũ��Ʈ�� ������Ʈ�� �߰� �� ���� ������Ʈ RectTransform����

        public void insert_Stuff(Stuff stf)
    {
        this.stf = stf;
    }

    public Stuff return_the_stuff(Stuff stf)
    {
        return stf;
    }


    // ������ ����� �߻��ϸ� ����Ǵ� �ݹ��Լ�.
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
