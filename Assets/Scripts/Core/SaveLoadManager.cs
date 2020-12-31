﻿using UnityEngine;

namespace Rhodos.Core
{
    public class SaveLoadManager : MonoBehaviour
    { 
        public static void IncreaseLevel(Level level, int order) => PlayerPrefs.SetInt("Level", GetLevel() + 1);
        public static int GetLevel() => PlayerPrefs.GetInt("Level", 0);
    }
}