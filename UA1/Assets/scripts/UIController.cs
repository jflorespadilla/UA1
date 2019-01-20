using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UIController : MonoBehaviour {
    [SerializeField] private Text scoreLabel;
    [SerializeField] private SettingPopup settingPopup;
    [SerializeField] private Slider speedSlider;

    private int _score;

    private void Awake() {
        Messenger.AddListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void OnDestroy() {
        Messenger.RemoveListener(GameEvent.ENEMY_HIT, OnEnemyHit);
    }

    private void Start() {
        _score = 0;
        scoreLabel.text = _score.ToString();

        settingPopup.Close();
        speedSlider.value = PlayerPrefs.GetFloat("speed", 1);
    }

    private void OnEnemyHit() {
        _score += 1;
        scoreLabel.text = _score.ToString();
    }

    public void OnOpenSettings() {
        settingPopup.Open();
    } 

    public void OnCloseSettings() {
        settingPopup.Close();
    }
}
