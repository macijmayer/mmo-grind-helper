```csharp
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

public class TrainerCore
{
    // Static addresses for Lost Ark-specific values
    private const int PLAYER_HEALTH_ADDRESS = 0x12345678; // Example address
    private const int PLAYER_EXPERIENCE_ADDRESS = 0x87654321; // Example address

    private Process _gameProcess;

    [DllImport("kernel32.dll")]
    private static extern IntPtr OpenProcess(int processAccess, bool bInheritHandle, int processId);

    [DllImport("kernel32.dll")]
    private static extern bool CloseHandle(IntPtr hObject);

    [DllImport("kernel32.dll")]
    private static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll")]
    private static extern bool WriteProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, byte[] lpBuffer, int dwSize, out int lpNumberOfBytesWritten);

    private const int PROCESS_VM_READ = 0x0010;
    private const int PROCESS_VM_WRITE = 0x0020;
    private const int PROCESS_VM_OPERATION = 0x0008;

    public void AttachToProcess()
    {
        _gameProcess = Process.GetProcessesByName("LostArk").FirstOrDefault();
        if (_gameProcess == null)
            throw new Exception("Lost Ark is not running.");
    }

    public bool IsGameRunning()
    {
        return _gameProcess != null && !_gameProcess.HasExited;
    }

    public float ReadFloat(int address)
    {
        IntPtr processHandle = OpenProcess(PROCESS_VM_READ, false, _gameProcess.Id);
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
        CloseHandle(processHandle);
        return BitConverter.ToSingle(buffer, 0);
    }

    public void WriteFloat(int address, float value)
    {
        IntPtr processHandle = OpenProcess(PROCESS_VM_WRITE | PROCESS_VM_OPERATION, false, _gameProcess.Id);
        byte[] buffer = BitConverter.GetBytes(value);
        WriteProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
        CloseHandle(processHandle);
    }

    public int ReadInt(int address)
    {
        IntPtr processHandle = OpenProcess(PROCESS_VM_READ, false, _gameProcess.Id);
        byte[] buffer = new byte[4];
        ReadProcessMemory(processHandle, (IntPtr)address, buffer, buffer.Length, out _);
        CloseHandle(processHandle);
        return BitConverter.ToInt32(buffer, 0);
    }

    public void WriteInt(int address, int value)
    {
        IntPtr processHandle = Open