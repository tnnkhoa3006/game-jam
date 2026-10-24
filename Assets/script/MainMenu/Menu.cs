// Dual Shift - customized edition by Trần Nguyễn Ngọc Khoa (Khoat0360).
// Licenses: see CODE LICENSE.md and THIRD_PARTY_NOTICES.md in the project root.
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Menu : MonoBehaviour
{
    public abstract void Show();
    public abstract void Hide();
    public abstract bool ShouldShowTitle();
    public abstract bool CanGoBack();
}
