using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_3 : Enemy            // Enemy_3 also extends the Enemy class
{
    [Header("Enemy_3 Inscribed Fields")]
    public float lifeTime = 5;
    public Vector2 midpointYRange = new Vector2(1.5f, 3);
    [Tooltip("If true, the Bezier points & path are drawn in the Scene pane.")]
    public bool drawDebugInfo = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
