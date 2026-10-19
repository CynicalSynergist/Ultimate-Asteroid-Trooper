using UnityEngine;

public class ShipColors : MonoBehaviour
{
    // Declare our variables
    public SpriteRenderer theRenderer; // renderer variable
    public Color spriteColor; // color variable

    // Initialization
        void Start()
    {
        // Load SpriteRenderer from object this component is on
        theRenderer = gameObject.GetComponent<SpriteRenderer>();
        // Change color from picker so alpha is 1
        spriteColor.a = 1.0f;
        // As long as theRenderer has been set
        if (theRenderer != null) 
        {
            //Randomly change the "color" value of the SpriteRenderer component once
            ChangeColorRandomly();
        }
    }

    void ChangeColorRandomly()
    {
        // Create random values between 0.0 and 1.0 for RGB
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);

        // Assign new color (Alpha 1.0 means fully opaque)
        theRenderer.color = new Color(r, g, b, 1.0f);

        Debug.Log("Color Change!");
    }
}