using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataBase : MonoBehaviour
{
    public GameObject _plane1, _plane2, _plane3;
    
    private void Start()
    {
        var other1 = _plane1.transform.position;
        
        var other2 = _plane2.transform.position;
        
        var other3 = _plane3.transform.position;
        
        _plane1 = Resources.Load("FirstLevel") as GameObject;
        _plane2 = Resources.Load("FirstLevel 2") as GameObject;
        _plane3 = Resources.Load("FirstLevel 3") as GameObject;
        Instantiate(_plane1,other1, transform.rotation) ;
        Instantiate(_plane2, other2, transform.rotation);
        Instantiate(_plane3, other3, transform.rotation);

    }
 
}
