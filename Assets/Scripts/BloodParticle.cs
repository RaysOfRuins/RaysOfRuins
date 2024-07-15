using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodParticle : MonoBehaviour
{
    public SpriteRenderer sp;

    public float bloodDuration;

    [Range(0f, 1f)]
    public float minSize;
    [Range(1f, 2f)]
    public float maxSize;
    [Range(0f, 3f)]
    public float offset;

    private void Start()
    {
        transform.localScale = Vector3.one * Random.Range(minSize, maxSize);
        Vector2 newOffset = Random.insideUnitCircle.normalized * Random.Range(0f, offset);
        
        transform.localPosition = transform.localPosition + new Vector3(newOffset.x, newOffset.y, 0);
        Destroy(gameObject, bloodDuration);
    }
}
