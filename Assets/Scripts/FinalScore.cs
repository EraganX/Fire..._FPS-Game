using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FinalScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _eCount;
    [SerializeField] private TMP_Text _cCount;
    [SerializeField] private TMP_Text _enemyMissed;
    [SerializeField] private TMP_Text _civilSaved;

    [SerializeField] GameObject _info;
    Score _scoreScript;

    private void Start()
    {
        _scoreScript = _info.GetComponent<Score>();
        
    }

    private void Update()
    {
        _eCount.text = _scoreScript.enemyCount.ToString();
        _cCount.text = _scoreScript.civilCount.ToString();
        _civilSaved.text = _scoreScript.civilSaved.ToString();
        _enemyMissed.text = _scoreScript.enemyMissed.ToString();
    }
}
