// PythonBridge.cs
using System.Diagnostics;
using UnityEngine;
public class PythonBridge : MonoBehaviour
{
    void Start()
    {
        RunPythonScript("CalculatorScript.py", "add", 5, 3);
        RunPythonScript("CalculatorScript.py", "subtract", 5, 3);
        RunPythonScript("CalculatorScript.py", "multiply", 5, 3);
        RunPythonScript("CalculatorScript.py", "divide", 5, 3);
        RunPythonScript("CalculatorScript.py", "divide", 5, 0); // Test divide by zero
    }

    void RunPythonScript(string scriptName, string functionName, params object[] args)
    {
        string pythonPath = "C:\\Python27\\python.exe"; // Replace with your Python executable path
        string scriptPath = Application.dataPath + "/" + scriptName;

        Process process = new Process();
        ProcessStartInfo startInfo = new ProcessStartInfo(pythonPath)
        {
            Arguments = scriptPath + " " + functionName + " " + string.Join(" ", args),
            RedirectStandardOutput = true,
            UseShellExecute = false,
            CreateNoWindow = true
        };

        process.StartInfo = startInfo;
        process.Start();

        string output = process.StandardOutput.ReadToEnd();
        process.WaitForExit();

        UnityEngine.Debug.Log("Python Output: " + output);
    }
}
