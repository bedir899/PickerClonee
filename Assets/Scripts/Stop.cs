using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Stop : MonoBehaviour
{


    [SerializeField] public int _MinCount;

    [SerializeField] public int _ballCount;

   

    [SerializeField] private TextMeshProUGUI _countText;
    private void Awake()
    {
        _countText.text = _ballCount + "/" + _MinCount;
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag=="ball")
        {
            _ballCount++;
            _countText.text = _ballCount + "/" + _MinCount;
            Destroy(other.gameObject);

        }

    }





}
