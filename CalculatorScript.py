# CalculatorScript.py
import UnityEngine as ui

def add(x, y):
    result = x + y
    unity_debug(f"Addition Result: {result}")
    return result

def subtract(x, y):
    result = x - y
    unity_debug(f"Subtraction Result: {result}")
    return result

def multiply(x, y):
    result = x * y
    unity_debug(f"Multiplication Result: {result}")
    return result

def divide(x, y):
    if y != 0:
        result = x / y
        unity_debug(f"Division Result: {result}")
        return result
    else:
        unity_debug("Cannot divide by zero.")
        return "Cannot divide by zero."

# Unity-specific debug function
def unity_debug(message):
    try:
        ui.Debug.Log(message)
    except ImportError:
        print("Unity Debug Log not available in this environment.")
