using UnityEngine;

public class ScriptEnabler : MonoBehaviour
{
    public MonoBehaviour scriptToControl;

    public void DisableScript()
    {
        if (scriptToControl != null)
            scriptToControl.enabled = false;
    }

    public void EnableScript()
    {
        if (scriptToControl != null)
            scriptToControl.enabled = true;
    }
}
