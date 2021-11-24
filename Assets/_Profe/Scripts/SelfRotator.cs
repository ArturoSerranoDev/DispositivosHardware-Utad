using UnityEngine;

/// <summary>
/// Rotates this component around the given axis
/// </summary>
public class SelfRotator : MonoBehaviour
{
    [SerializeField] private Vector3 rotationAxis = Vector3.up;
    [SerializeField] private bool randomAxis;
    
    void Start()
    {
        rotationAxis = randomAxis ? GetRamdomAxis() : rotationAxis.normalized;
    }

    void Update()
    {
        Rotate(1000f);
    }

    void Rotate(float speed)
    {
        this.transform.Rotate(rotationAxis * speed * Time.deltaTime, Space.World);
    }
    
    private Vector3 GetRamdomAxis()
    {
        return new Vector3(Random.Range(-0.1f, 0.1f), 
                           Random.Range(0.9f, 1f), 
                           Random.Range(-0.1f, 0.1f));
    }
    
#if UNITY_EDITOR
    private void OnDrawGizmosSelected()
    {
        Debug.DrawRay(this.transform.position, rotationAxis.normalized * 5, Color.red);
    }
#endif

}
