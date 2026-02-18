using UnityEngine;
using System.Collections;


public class MoleScript : MonoBehaviour
{
    public float minTimer = 2f; //Min amount it will take until mole goes up
    public float maxTimer = 9f; //Max amount is will take until mole goes up

    public float upDuration = 1.5f; //How long the moles stay up at a time

    public ScoreScript scoreScript;
    public bool isUp;

    private Animator animator;
    private float currentValue;
    


    Vector3 mousePosition;
    RaycastHit2D raycastHit2D;
    Transform clickObject;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    void Start()
    {
        currentValue = Mathf.Clamp(0f, minTimer, maxTimer);
        StartCoroutine(randomizedTimer()); //Start of the game
    }

    void Update()
    {
        //All of this is the mouse click input so that it can trigger OnMouseDown

        mousePosition = Input.mousePosition;
        Ray mouseRay = Camera.main.ScreenPointToRay(mousePosition);
        

        if (Input.GetMouseButtonDown(0))
        {
            raycastHit2D = Physics2D.Raycast(mouseRay.origin, mouseRay.direction);
            clickObject = raycastHit2D ? raycastHit2D.collider.transform : null;

            if (clickObject && isUp)
            {
                OnMouseDown();
            }
        }
    }

    IEnumerator randomizedTimer()

    //No idea what IEnumerator does, but it helps with numbers and time

    {
        while (true)
        {
            float randomTime = Random.Range(minTimer, maxTimer); //Gets random time number

            yield return new WaitForSeconds(randomTime); //Waits for said random timer

            //Makes mole go up
            animator.SetBool("isGoingDown", false);
            animator.SetBool("isGoingUp", true);
           
            

            Debug.Log("Mole is going up after: " + randomTime);

            //Makes mole stay up for a while
            yield return new WaitForSeconds(upDuration);

            //Makes mole go back down after a while
            animator.SetBool("isGoingUp", false);
            animator.SetBool("isGoingDown", true);
            

            Debug.Log("Mole is going down after: " + randomTime);
        }
    }

    void OnMouseDown()
    {
        //When mole gets hit, it goes down
        animator.SetBool("isGoingUp", false);
        animator.SetBool("isGoingDown", true);

        Debug.Log("Mole is going down");

        //Adds a point to score
      
            scoreScript.AddPoint();
            isUp = false;
        
        

        Debug.Log("You gained a point!");
    }
}