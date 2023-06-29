using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    [SerializeField]private TMP_Text _eCount;
    [SerializeField]private TMP_Text _cCount;
    [SerializeField]private TMP_Text _aCount = null;
    [SerializeField]private TMP_Text _enemyMissed;
    [SerializeField]private TMP_Text _civilSaved;

    public int ammoCount = 0;
    public int enemyCount = 0;
    public int civilCount = 0;
    public int civilSaved = 0;
    public int enemyMissed = 0;

    private void Update()
    {
        
        if (_aCount != null)
        {
            _aCount.text = ammoCount.ToString();
        }
        _eCount.text = enemyCount.ToString();
        _cCount.text = civilCount.ToString();
        _civilSaved.text = civilSaved.ToString();
        _enemyMissed.text = enemyMissed.ToString();
    }
}
