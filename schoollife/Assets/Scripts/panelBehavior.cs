using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panelBehavior : MonoBehaviour
{
    public RectTransform panelRectTransform;
    // Start is called before the first frame update
    void Start()
    {
        // Puts the panel to the front as it is now the last UI element to be drawn.
        panelRectTransform.SetAsLastSibling();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
