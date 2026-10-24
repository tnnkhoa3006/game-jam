// Dual Shift - customized edition by Trần Nguyễn Ngọc Khoa (Khoat0360).
// Licenses: see CODE LICENSE.md and THIRD_PARTY_NOTICES.md in the project root.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Each level should have one object "LevelIdentifier_[ID]" with tag "LevelIdentifier"
/// and this script attached. It is only a way to associate a scene with Level Data.
public class LevelIdentifier : MonoBehaviour
{
    [Header("Data")]
    
    [Tooltip("Level Data associated to this level scene")]
    public LevelData levelData;
}
