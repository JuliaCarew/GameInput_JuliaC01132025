using System;


public static class ActionManager
{
    // jump / sphere actions
    public static Action OnJumpStarted;
    public static Action OnJumpPerformed;
    public static Action OnJumpCancelled;
    // T / cube actions
    public static Action OnInteractStarted;
    public static Action OnInteractPerformed;
    public static Action OnInteractCancelled;
    // Tab / block actions
    public static Action OnCrouchStarted;
    public static Action OnCrouchPerformed;
    public static Action OnCrouchCancelled;

}
