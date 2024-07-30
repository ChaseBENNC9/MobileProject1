
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    private GolfGameInputActions inputActions;
    void Awake()
    {
        inputActions = new GolfGameInputActions();
    }

    void OnEnable()
    {
        inputActions.Enable();
    }

    void OnDisable()
    {
        inputActions.Disable();
    }
    void Start()
    {
        inputActions.Mobile.TouchPress.started += context => TouchStart(context);
        inputActions.Mobile.TouchPress.canceled += context => TouchEnd(context);
        inputActions.Mobile.Drag.started += context => OnDrag(context);

    }

    private void TouchStart(InputAction.CallbackContext context)
    {
        {
            PlayerController.i.startPos = Vector3.zero;
            Vector2 mousePos = inputActions.Mobile.TouchPos.ReadValue<Vector2>();
            Ray ray = Camera.main.ScreenPointToRay(mousePos);

            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                if (hit.collider.gameObject.name == "GolfBall")
                {
                    PlayerController.i.startPos = new(hit.collider.gameObject.transform.position.x, 0, hit.collider.gameObject.transform.position.z);
                    Debug.Log("Start Pos: " + PlayerController.i.startPos);
                    PlayerController.i.line.enabled = true;
                    PlayerController.i.line.positionCount = 1;
                    PlayerController.i.line.SetPosition(0, PlayerController.i.startPos);
                }
                else
                {
                    {
                        GameObject p = GameObject.Find("GolfBall");
                        PlayerController.i.startPos = new(p.transform.position.x, 0, p.transform.position.z);
                        PlayerController.i.line.enabled = true;
                        PlayerController.i.line.positionCount = 2;
                        PlayerController.i.line.SetPosition(0, PlayerController.i.startPos);
                        PlayerController.i.endPos = new(hit.point.x, 0, hit.point.z);
                        PlayerController.i.line.SetPosition(1,PlayerController.i.endPos);
                    }
                }



            }

        }

    }
    private Vector3 ScreenToWorld(Vector2 mousePos)
    {
        Ray ray = Camera.main.ScreenPointToRay(mousePos);
        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            Debug.Log("Hit: " + hit.collider.gameObject.name);
            return new(hit.point.x, 0, hit.point.z);
        }
        return Vector3.zero;
    }

    private Vector3 PositionDifference(Vector3 start, Vector3 end)
    {
        return new(end.x - start.x, 0, end.z - start.z);
    }
    private void OnDrag(InputAction.CallbackContext context)
    {
        if (PlayerController.i.startPos == Vector3.zero || PlayerController.i.line.GetPosition(0) == Vector3.zero)
        {
            return;
        }
        Debug.Log("Currently Moving At Pos " + ScreenToWorld(inputActions.Mobile.TouchPos.ReadValue<Vector2>()) + " From " + PlayerController.i.startPos + " which is a delta of " + PositionDifference(PlayerController.i.startPos, ScreenToWorld(inputActions.Mobile.TouchPos.ReadValue<Vector2>())));
        PlayerController.i.line.positionCount = 2;
        PlayerController.i.line.SetPosition(1, ScreenToWorld(inputActions.Mobile.TouchPos.ReadValue<Vector2>()));
        PlayerController.i.endPos = ScreenToWorld(inputActions.Mobile.TouchPos.ReadValue<Vector2>());


    }
    private void TouchEnd(InputAction.CallbackContext context)
    {
        if (PlayerController.i.startPos == Vector3.zero || PlayerController.i.line.GetPosition(0) == Vector3.zero)
        {
            return;
        }
        // Ray ray = Camera.main.ScreenPointToRay(inputActions.Mobile.TouchPos.ReadValue<Vector2>());
        // if (Physics.Raycast(ray, out RaycastHit hit))
        // {
        //     {
        //         PlayerController.i.endPos = new(hit.point.x, 0, hit.point.z);
        // Debug.Log("End Pos: " + PlayerController.i.endPos);
        if (PlayerController.i.startPos != PlayerController.i.endPos && PlayerController.i.startPos != Vector3.zero)
        {

            PlayerController.i.line.enabled = false;
            Debug.Log("Apply Force" + PositionDifference(PlayerController.i.startPos, PlayerController.i.endPos));
            PlayerController.i.Launch(PositionDifference(PlayerController.i.startPos, PlayerController.i.endPos));
        }
        //     }
        // }


    }


}