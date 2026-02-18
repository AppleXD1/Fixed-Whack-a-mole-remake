using UnityEngine;

public class MouseInputScript : MonoBehaviour
{
   Vector3 mousePosition;
   RaycastHit2D raycastHit2D;
   Transform clickObject;


    void Start()
    {
        
    }

    
    void Update()
    {
        mousePosition = Input.mousePosition;

        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (clickObject)
            {
               // clickObject.GetComponent<OnMouseDown>();
            }
        }
    }
}
