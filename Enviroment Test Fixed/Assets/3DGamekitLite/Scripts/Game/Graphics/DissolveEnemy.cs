using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveEnemy : MonoBehaviour
{

public MeshRenderer meshRenderer;
public float dissolveRate = 0.02f; 
public float refreshRate = 0.05f;
public float dieDelay = 0.2f;
 float startTime;
 public float fadeDelay = 3f;
  public float counter;
    public float intensity;
    public float intensityMin;
    public float intensityMax;
     public float fadeInTime = 1f;

private Material [] dissolveMaterials;

    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.deltaTime;
        if(meshRenderer != null)dissolveMaterials = meshRenderer.materials;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine (Dissolve());
Debug.Log("space");
        }
    }

    IEnumerator Dissolve ()
    {
Debug.Log("Disolve");
//yield return new WaitForSeconds (dieDelay);

    
 for (float t = 0.01f; t < fadeInTime; t += 0.1f)
        {
            intensity = Mathf.Lerp(intensityMin, intensityMax, t / fadeInTime);
            yield return null;

        }
        yield return new WaitForSeconds(fadeDelay);

    counter = 0;

    if(dissolveMaterials.Length > 0)

    {
//while(dissolveMaterials[0].GetFloat("DissolveAmount_") < 1)
{

   // intensity += dissolveRate;
    for(int i=0; i<dissolveMaterials.Length; i++)
    dissolveMaterials[i].SetFloat("DissolveAmount_", intensity);

    yield return new WaitForSeconds (refreshRate);
    
    }

    }
   // Destroy(gameObject, 5);
    }
}


