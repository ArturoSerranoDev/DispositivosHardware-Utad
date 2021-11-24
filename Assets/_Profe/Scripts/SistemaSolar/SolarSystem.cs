using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class SolarSystem : MonoBehaviour
{
    [SerializeField, Range(0f,200f)] private float systemSpeed = 1f;
    
    private List<SelfRotator> planetRotators = new List<SelfRotator>();
    
    private void Awake()
    {
        planetRotators = FindObjectsOfType<SelfRotator>().ToList();
    }
    
    void Update()
    {
        foreach (var planetRotator in planetRotators)
        {
            planetRotator.RotateSelf(systemSpeed);
            
            // Rotate each planet relative to the distance to Sun
            float distanceToCenter = Vector3.Distance(this.transform.position, planetRotator.transform.position);

            float axisSpeed = 1f / distanceToCenter * 10f;
            
            planetRotator.transform.RotateAround(this.transform.position, 
                                                Vector3.up, 
                                                systemSpeed * axisSpeed
                                                            * Time.deltaTime);
        }
 
    }
}
