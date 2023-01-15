using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;

namespace EngineKit.Native.OpenGL.Tests.Infrastructure;

public sealed class GlfwOpenGLDummyWindow : IDisposable
{
    private readonly nint _windowHandle;
    private GL.GLDebugProc _debugProcCallback;

    public IList<string> WarningMessages { get; }

    public IList<string> ErrorMessages { get; }

    public IList<string> InfoMessages { get; }

    public IList<string> DebugMessages { get; }

    public GlfwOpenGLDummyWindow()
    {
        _debugProcCallback = DebugCallback;
        WarningMessages = new List<string>();
        ErrorMessages = new List<string>();
        InfoMessages = new List<string>();
        DebugMessages = new List<string>();

        Glfw.Glfw.Init();
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.Profile, Glfw.Glfw.OpenGLProfile.Core);
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.VersionMajor, 4);
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.VersionMinor, 6);
        _windowHandle = Glfw.Glfw.CreateWindow(100, 100, "OpenGLTests", nint.Zero, nint.Zero);
        Glfw.Glfw.MakeContextCurrent(_windowHandle);

        GL.DebugMessageCallback(_debugProcCallback, nint.Zero);
        GL.Enable(GL.EnableType.DebugOutput);
        GL.Enable(GL.EnableType.DebugOutputSynchronous);

        Thread.Sleep(500);
    }

    public void Dispose()
    {
        Thread.Sleep(1000);
        Glfw.Glfw.DestroyWindow(_windowHandle);
        Thread.Sleep(500);
        Glfw.Glfw.Terminate();
    }

    private void DebugCallback(
        GL.DebugSource source,
        GL.DebugType type,
        uint id,
        GL.DebugSeverity severity,
        int length,
        nint messagePtr,
        nint userParam)
    {
        if (type is GL.DebugType.Portability or GL.DebugType.Other or GL.DebugType.PushGroup or GL.DebugType.PopGroup)
        {
            return;
        }

        var message = Marshal.PtrToStringAnsi(messagePtr, length);

        if (type == GL.DebugType.Error)
        {
            ErrorMessages.Add(message);
        }
        else
        {
            switch (severity)
            {
                case GL.DebugSeverity.Notification or GL.DebugSeverity.DontCare:
                    DebugMessages.Add($"GL: {type} | {message}");
                    break;
                case GL.DebugSeverity.High:
                    ErrorMessages.Add($"GL: {type} | {message}");
                    break;
                case GL.DebugSeverity.Medium:
                    WarningMessages.Add($"GL: {type} | {message}");
                    break;
                case GL.DebugSeverity.Low:
                    InfoMessages.Add($"GL: {type} | {message}");
                    break;
            }
        }
    }
}