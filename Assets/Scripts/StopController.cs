using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
public class StopController : MonoBehaviour
{


    [SerializeField] private GameObject _groundev;
    
    [SerializeField] private GameObject _door;

    [SerializeField] private Stop _stopsn;

    private bool _work = true;

    private bool _wait = false;

    [SerializeField] private bool _lp;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.tag == "FirstStage")
        {
            
           
            StartCoroutine(WaitBalls());
        }

    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && gameObject.tag == "FirstStage")
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
                        StartCoroutine(departure());
                    }
                }
            }
            
            else if (_wait && _stopsn._ballCount < _stopsn._MinCount)
            {
              
                gameObject.tag = "Untagged";
            }

        }
    }
    IEnumerator departure()
    {
        _groundev.transform.DOMove(new Vector3(_groundev.transform.position.x, 1.82f, 0), 2f, false);
        _door.transform.DOMoveY(4f, 2f);

        yield return new WaitForSeconds(3f);
        _stopsn._ballCount = 0;
    }
    private void nl()
    {
        _door.transform.DOMoveY(4f, 2f);
        _groundev.transform.DOMove(new Vector3(_groundev.transform.position.x, 1.82f, 0), 2f, false);
       
    }
    IEnumerator WaitBalls()
    {
        yield return new WaitForSeconds(6f);
        _wait = true;
    }

}
