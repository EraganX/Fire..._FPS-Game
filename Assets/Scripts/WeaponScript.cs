using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WeaponScript : MonoBehaviour
{
    [SerializeField] private ParticleSystem _muzzleSplash;
    [SerializeField] private float _maxDistance = 100f;
    [SerializeField] private int bullets;
    [SerializeField] private GameObject 
        _hitMarker,
        _info,
        _over;
    [SerializeField] private GameObject _weapon;


    private Score scoreScript;

    private void Start()
    {
        _info.SetActive(true);
        _over.SetActive(false);

        scoreScript = _info.GetComponent<Score>();
        scoreScript.ammoCount = bullets;
        StopMuzzleSplash();
    }

    private void Update()
    {
        if (bullets > 0)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                _muzzleSplash.Play();
                _weapon.transform.localScale = new Vector3(1, 1, _weapon.transform.localScale.z + 0.01f);
                Invoke("StopMuzzleSplash", 0.1f);
                WeaponShoot();
                bullets--;
                scoreScript.ammoCount = bullets;
            }
        }
        else
        {
            _info.SetActive(false);
            _over.SetActive(true);
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }

    private void StopMuzzleSplash()
    {
        _weapon.transform.localScale = new Vector3(1, 1, _weapon.transform.localScale.z - 0.01f);
        _muzzleSplash.Stop();
    }

    private void WeaponShoot()
    {
        RaycastHit _hitInfo;

        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out _hitInfo, _maxDistance))
        {
            projectHitmarker(_hitInfo);

            if (_hitInfo.transform.CompareTag("Targets"))
            {
                scoreScript.enemyCount++;
                Destroy(_hitInfo.transform.gameObject);
            }
            if (_hitInfo.transform.CompareTag("Civil"))
            {
                scoreScript.civilCount++;
                Destroy(_hitInfo.transform.gameObject);
            }
        }
        else
        {
            return;
        }
    }

    private void projectHitmarker(RaycastHit hitInfo)
    {
        GameObject cloneMarker = Instantiate(_hitMarker, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
        Destroy(cloneMarker, 1f);
    }
}
