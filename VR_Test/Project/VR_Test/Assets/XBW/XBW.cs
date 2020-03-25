using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class XBW : MonoBehaviour
{

    void Awake()
    {
    }
    // Start is called before the first frame update
    void Start()
    {
        var canvas = GetComponent<Canvas>();
        Vector2 p = new Vector2(Screen.width / 2.0f, Screen.height / 2.0f);
        p = new Vector2(-1000, -10000);
        var allGraphics = GraphicRegistry.GetGraphicsForCanvas(canvas);
        for(int i = 0;i<allGraphics.Count;i++) {
            var g = allGraphics[i];
            bool con = RectTransformUtility.RectangleContainsScreenPoint(g.rectTransform, p, Camera.main);
            Debug.LogError(g.Raycast(p, Camera.main) + "  " + g.name+" "+con);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  
}
