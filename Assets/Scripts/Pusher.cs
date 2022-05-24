using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Pusher : MonoBehaviour
{
    [SerializeField] private float _force;
    [SerializeField] private GameObject _pusher;
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        Rigidbody _rb = hit.collider.attachedRigidbody;
        if (_rb != null)
        {
            
            Vector3 forceDirection = hit.gameObject.transform.position - transform.position;
            forceDirection.y = 0;
            forceDirection.Normalize();
            _rb.AddForceAtPosition(forceDirection * _force, transform.position, ForceMode.Impulse);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("FirstStage"))
        {
            _pusher.transform.DOLocalMove(new Vector3(_pusher.transform.localPosition.x, _pusher.transform.localPosition.y), 2f, false);
            StartCoroutine(departure());
        }

    }
    IEnumerator departure()
    {
        yield return new WaitForSeconds(2f);
        _pusher.transform.localPosition = new Vector3(0, 0.314f, 2.4f);

    }

}
