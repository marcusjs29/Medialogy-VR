using UnityEngine;
using UnityEngine.InputSystem;

public class NewMonoBehaviourScript : MonoBehaviour
{

    public InputActionProperty grabAction;
    public InputActionProperty triggerAction;

    public Animator myAnimator;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float grabValue = grabAction.action.ReadValue<float>();
        myAnimator.SetFloat("grab", grabValue);
        
        float triggerValue = triggerAction.action.ReadValue<float>();
        myAnimator.SetFloat("trigger", triggerValue);
    }
}
