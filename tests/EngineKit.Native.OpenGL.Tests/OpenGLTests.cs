using EngineKit.Native.OpenGL.Tests.Infrastructure;
using FluentAssertions;
using Xunit;

namespace EngineKit.Native.OpenGL.Tests;

// ReSharper disable once ClassNeverInstantiated.Global
[Collection("Serial-Test-Collection")]
public class OpenGLTests : IClassFixture<GlfwOpenGLDummyWindow>
{
    // ReSharper disable once NotAccessedField.Local
    private readonly GlfwOpenGLDummyWindow _dummyWindow;

    public OpenGLTests(GlfwOpenGLDummyWindow dummyWindow)
    {
        _dummyWindow = dummyWindow;
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