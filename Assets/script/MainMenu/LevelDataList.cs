// Dual Shift - customized edition by Khoat0360.
// Original authors and licenses: see THIRD_PARTY_NOTICES.md in the project root.
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