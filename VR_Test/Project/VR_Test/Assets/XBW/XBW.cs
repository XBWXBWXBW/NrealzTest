using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class XBW : MonoBehaviour , IPointerEnterHandler
{
    private MeshRenderer m_MeshRender;

    void Awake()
    {
        m_MeshRender = transform.GetComponent<MeshRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        m_MeshRender.material.color = Color.green;
    }
}
