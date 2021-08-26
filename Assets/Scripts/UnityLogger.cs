using UnityEngine;
using System.Diagnostics;

public class UnityLogger : MonoBehaviour
{
    public static void PrintStackTrace(string message)
    {
        string warningMessage = message;

        StackTrace stack = new StackTrace();
        for(int i = 0; i < stack.FrameCount; i++)
        {
            StackFrame frame = stack.GetFrame(i);
            warningMessage += "\n" + frame.GetFileName() + '#' + frame.GetMethod() + '[' + frame.GetFileLineNumber() + ']';
        }

        UnityEngine.Debug.Log(message);
    }
}
