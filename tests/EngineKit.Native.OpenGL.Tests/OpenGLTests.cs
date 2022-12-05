using System;
using System.Threading;
using FluentAssertions;
using Xunit;

namespace EngineKit.Native.OpenGL.Tests;

public sealed class GlfwContext : IDisposable
{
    private readonly IntPtr _windowHandle;

    public GlfwContext()
    {
        Glfw.Glfw.Init();
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.Profile, Glfw.Glfw.OpenGLProfile.Core);
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.VersionMajor, 4);
        Glfw.Glfw.WindowHint(Glfw.Glfw.WindowOpenGLContextHint.VersionMinor, 6);
        _windowHandle = Glfw.Glfw.CreateWindow(100, 100, "OpenGLTests", IntPtr.Zero, IntPtr.Zero);
        Glfw.Glfw.MakeContextCurrent(_windowHandle);
        Thread.Sleep(500);
    }

    public void Dispose()
    {
        Thread.Sleep(1000);
        Glfw.Glfw.DestroyWindow(_windowHandle);
        Thread.Sleep(500);
        Glfw.Glfw.Terminate();
    }
}

public class OpenGLTests : IClassFixture<GlfwContext>
{
    private readonly GlfwContext _context;


    public OpenGLTests(GlfwContext context)
    {
        _context = context;
    }

    [Fact]
    public void CreateAndDeleteBuffer()
    {
        var buffer = GL.CreateBuffer();
        buffer.Should().NotBe(0);
        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public void CreateAndDeleteFramebuffer()
    {
        var texture = GL.CreateFramebuffer();
        texture.Should().NotBe(0);
        GL.DeleteFramebuffer(texture);
    }

    [Fact]
    public void CreateAndDeleteQuery()
    {
        var query = GL.CreateQuery(GL.QueryTarget.TimeElapsed);
        query.Should().NotBe(0);
        GL.DeleteQuery(query);
    }

    [Fact]
    public void CreateAndDeleteSampler()
    {
        var sampler = GL.CreateSampler();
        sampler.Should().NotBe(0);
        GL.DeleteSampler(sampler);
    }

    [Fact]
    public void CreateAndDeleteTexture()
    {
        var texture = GL.CreateTexture(GL.TextureTarget.Texture2d);
        texture.Should().NotBe(0);
        GL.DeleteTexture(texture);
    }

    [Fact]
    public void CreateAndDeleteProgramPipeline()
    {
        var programPipeline = GL.CreateProgramPipeline();
        programPipeline.Should().NotBe(0);
        GL.DeleteProgramPipeline(programPipeline);
    }

    [Fact]
    public void CreateAndDeleteShaderProgram()
    {
        var shaderProgram = GL.CreateShaderProgram(GL.ShaderType.VertexShader, "#version 460 core\n\nvoid main() {}");
        shaderProgram.Should().NotBe(0);
        GL.DeleteProgram(shaderProgram);
    }

    [Fact]
    public void CreateAndDeleteVertexArray()
    {
        var vertexArray = GL.CreateVertexArray();
        vertexArray.Should().NotBe(0);
        GL.DeleteVertexArray(vertexArray);
    }
}