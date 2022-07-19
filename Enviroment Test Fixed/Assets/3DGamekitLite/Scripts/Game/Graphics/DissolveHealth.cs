using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[RequireComponent(typeof(Renderer))]
public class DissolveHealth : MonoBehaviour
{
   // [SerializeField] private Health health = null;
    [SerializeField] private Renderer[] healthRenderers = new Renderer[0];

   
 public float timer = 0;
  public float timeRemaining = 10;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
      if (timeRemaining > -1)
        {
            timeRemaining -= Time.deltaTime;
        }
          //  timer += 0.01f;
          foreach (Renderer renderer in healthRenderers)
        {

            renderer.material.SetFloat("_Health", timeRemaining);

             Destroy(gameObject, 12);
        }
        }
    }
