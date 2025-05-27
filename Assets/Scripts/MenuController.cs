using UnityEngine;
using UnityEngine.InputSystem;

public class MenuController : MonoBehaviour
{
    public GameObject menuCanvas;
    private InputAction toggleMenuAction;

    private void Awake()
    {
        toggleMenuAction = new InputAction(type: InputActionType.Button, binding: "<Keyboard>/tab");
        toggleMenuAction.performed += _ => menuCanvas.SetActive(!menuCanvas.activeSelf);
    }

    private void OnEnable()
    {
        toggleMenuAction.Enable();
    }

    private void OnDisable()
    {
        toggleMenuAction.Disable();
    }

    private void Start()
    {
        menuCanvas.SetActive(false);
    }
}