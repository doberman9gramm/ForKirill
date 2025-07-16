using System;
using UnityEngine;

public class ScoreSystem : MonoBehaviour
{
    public static event Action<int> OnScoreChanged;

    private int currentScore = 0;

    private void OnEnable()
    {
        Target.OnHit += HandleTargetHit;
    }

    private void OnDisable()
    {
        Target.OnHit -= HandleTargetHit;
    }

    private void Start()
    {
        OnScoreChanged?.Invoke(currentScore);
    }

    private void HandleTargetHit()
    {
        currentScore++;
        Debug.Log("Попадание!");
        Debug.Log("Текущий счет: " + currentScore);
        OnScoreChanged?.Invoke(currentScore);
    }
}