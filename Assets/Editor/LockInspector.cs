using UnityEngine;
using UnityEditor;

public static class LockInspector
{
	[MenuItem ("GameObject/Lock Inspector", false, -1)]
	public static void Lock ()
	{
		ActiveEditorTracker.sharedTracker.isLocked = !ActiveEditorTracker.sharedTracker.isLocked;
		ActiveEditorTracker.sharedTracker.ForceRebuild ();
	}
}
