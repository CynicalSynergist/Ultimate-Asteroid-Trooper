using UnityEngine;

public class ShipColor : MonoBehaviour
{
    // Declare variables
    public SpriteRenderer theRenderer; // renderer variable
    public Color spriteColor; // color variable

    // Initialization
    void Start ()
    {
        // Load SpriteRenderer from same object this component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        // Change color from picker so Alpha is 1
        spriteColor.a = 1.0f;
        // Makes color values random with range between 0 and 1
        spriteColor.r = Random.Range(0.0f, 1.0f);
        spriteColor.g = Random.Range(0.0f, 1.0f);
        spriteColor.b = Random.Range(0.0f, 1.0f);
        // As long as theRenderer has been set
        if (theRenderer !=null)
        {
            // Change the "color" value of SpriteRenderer to new color
            theRenderer.color = spriteColor;
        }
    }

    // Update is called once per frame
    void Update ()
    {

    }
}