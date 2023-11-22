using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        
    }
    public void Rotate()
    {
        this.gameObject.SetActive(true);
        transform.DORotate(new Vector3(90f, 360f, 90f), 1.5f, RotateMode.FastBeyond360);
    }

    
}
