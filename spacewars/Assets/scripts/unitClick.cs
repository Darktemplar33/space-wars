
using UnityEngine;

public class unitClick : MonoBehaviour
{

    public Camera myCam;

    public LayerMask clickable;
    public LayerMask ground;

    void Start()
    {
       
    }

  
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            RaycastHit hit;
            Ray ray = myCam.ScreenPointToRay(Input.mousePosition);

            if(Physics.Raycast(ray, out hit, Mathf.Infinity, clickable))
            {
                //we hit a clickable object
                if (Input.GetKey(KeyCode.LeftShift))
                {
                    //shift click
                    UnitSelections.Instance.ShiftClickSelect(hit.collider.gameObject);
                }
                else
                {
                    //normal click
                    UnitSelections.Instance.ClickSelect(hit.collider.gameObject);

                }

            }
            else{
                //we dont
                if (!Input.GetKey(KeyCode.LeftShift))
                {
                    UnitSelections.Instance.DeselectAll();
                }
            }
        }
    }
}
