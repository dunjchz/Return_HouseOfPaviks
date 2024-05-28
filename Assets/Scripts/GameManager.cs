using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private bool lock1Solved = false;
    private bool lock2Solved = false;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SetLockSolved(int lockNumber)
    {
        if (lockNumber == 1)
        {
            lock1Solved = true;
        }
        else if (lockNumber == 2)
        {
            lock2Solved = true;
        }
    }

    public bool AreAllLocksSolved()
    {
        return lock1Solved && lock2Solved;
    }
}
