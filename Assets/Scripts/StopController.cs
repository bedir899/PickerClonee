using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class StopController : MonoBehaviour
{


    [SerializeField] private GameObject _groundev;
    
    [SerializeField] private GameObject _door;
    private Collider _this;

    [SerializeField] private Stop _stopsn;
    [SerializeField] public Movement _move;

    private bool _work = true;

    private bool _wait = false;

    [SerializeField] public bool _lp;
    private void Awake()
    {
        _this = GetComponent<Collider>();
    }

    
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Player")
        {
           
            if (_stopsn._ballCount >= _stopsn._MinCount)
            {
                if (_work)
                {
                    _work = false;
                    if (_lp)
                    {
                        gameObject.tag = "Untagged";
                        
                        nl();
       
                    }
                    else
                    {
                        
                        gameObject.tag = "Untagged";
                        StartCoroutine(up());
                    }
                }
            }
            
            else if (_wait && _stopsn._ballCount < _stopsn._MinCount)
            {
              
                gameObject.tag = "Untagged";
                Debug.Log("Olmadi");
            }

        }
    }
    IEnumerator up()
    {
        _groundev.transform.DOLocalMoveY(1.82f, 2f);
        _door.transform.DOMoveY(4f, 2f);
        _this.isTrigger = true;

        yield return new WaitForSeconds(3f);
       
        _stopsn._ballCount = 0;
    }
    private void nl()
    {
        _this.isTrigger = true;
        _door.transform.DOMoveY(4f, 2f);
        _groundev.transform.DOMoveY(1.82f,2f,false);
       

    }
   

}
