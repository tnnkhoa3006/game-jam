// Dual Shift - customized edition by Trần Nguyễn Ngọc Khoa (Khoat0360).
// Licenses: see CODE LICENSE.md and THIRD_PARTY_NOTICES.md in the project root.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// Level Data List
/// References on Level Data in order, to easily retrieve them by level index.
[CreateAssetMenu(fileName = "LevelDataList", menuName = "Data/Level Data List")]
public class LevelDataList : ScriptableObject
{
    [Tooltip("Array of references to Level Data, indexed by level index")]
    public LevelData[] levelDataArray;
}