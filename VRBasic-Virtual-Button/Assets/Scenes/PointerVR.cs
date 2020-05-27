using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointerVR : MonoBehaviour
{
    public Material active, Default;
    private Renderer myRenderer;

    private void Start()
    {
        myRenderer = GetComponent<Renderer>();
        SetGazedAt(false);
    }

    public void SetGazedAt(bool gazedAt)
    {
        if (Default != null && active != null)
        {
            myRenderer.material = gazedAt ? active : Default;
            return;
        }
    }
}
