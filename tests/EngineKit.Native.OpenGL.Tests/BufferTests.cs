using System;
using System.Threading;
using EngineKit.Native.OpenGL.Tests.Infrastructure;
using FluentAssertions;
using OpenTK.Mathematics;
using Xunit;

namespace EngineKit.Native.OpenGL.Tests;

[Collection("Serial-Test-Collection")]
public class BufferTests : IClassFixture<GlfwOpenGLDummyWindow>
{
    // ReSharper disable once NotAccessedField.Local
    private readonly GlfwOpenGLDummyWindow _dummyWindow;

    // ReSharper disable once MemberCanBePrivate.Global
    public struct BufferData
    {
        public Vector3i Position;
    }

    public BufferTests(GlfwOpenGLDummyWindow dummyWindow)
    {
        _dummyWindow = dummyWindow;
        Thread.Sleep(800);
    }

    [Fact]
    public void CreateUninitializedBuffer()
    {
        // Arrange & Act
        var buffer = GL.CreateBuffer();

        // Assert
        buffer.Should().NotBe(0);
        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public void AllocateWithArrayOfData()
    {
        var buffer = GL.CreateBuffer();
        // Arrange & Act
        var arrayOfData = new BufferData[]
        {
            new BufferData(),
            new BufferData(),
        };
        GL.NamedBufferStorage(buffer, arrayOfData, 0);

        // Assert
        _dummyWindow.ErrorMessages.Should().HaveCount(0);
        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public void AllocateWithFixedSizeThenUpdateWithArrayOfDataShouldRaiseErrorWhenBufferStorageIsNotDynamic()
    {
        // Arrange
        var buffer = GL.CreateBuffer();
        GL.NamedBufferStorage(buffer, 0x1000, nint.Zero, 0);

        // Act
        var arrayOfData = new BufferData[]
        {
            new BufferData(),
            new BufferData(),
        };
        GL.NamedBufferSubData(buffer, 0, arrayOfData);

        // Assert
        _dummyWindow.ErrorMessages.Should()
            .Contain(
                "GL_INVALID_OPERATION error generated. Buffer contents cannot be modified because the buffer was created without the GL_DYNAMIC_STORAGE_BIT set.");
        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public void AllocateWithFixedSizeThenUpdateWithArrayOfDataShouldNotRaiseErrorWhenBufferStorageIsDynamic()
    {
        // Arrange
        var buffer = GL.CreateBuffer();
        GL.NamedBufferStorage(buffer, 0x1000, nint.Zero, GL.BufferStorageMask.DynamicStorageBit);

        // Act
        var arrayOfData = new BufferData[]
        {
            new BufferData(),
            new BufferData(),
        };
        GL.NamedBufferSubData(buffer, 0, arrayOfData);

        // Assert
        _dummyWindow.ErrorMessages.Should().HaveCount(0);

        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public void AllocateWithFixedSizeThenUpdateWithDataShouldRaiseErrorWhenBufferStorageIsNotDynamic()
    {
        // Arrange
        var buffer = GL.CreateBuffer();
        GL.NamedBufferStorage(buffer, 0x1000, nint.Zero, 0);

        // Act
        var data = new BufferData();

        GL.NamedBufferSubData(buffer, 0, data);

        // Assert
        _dummyWindow.ErrorMessages.Should()
            .Contain(
                "GL_INVALID_OPERATION error generated. Buffer contents cannot be modified because the buffer was created without the GL_DYNAMIC_STORAGE_BIT set.");
        GL.DeleteBuffer(buffer);
    }

    [Fact]
    public unsafe void AllocateWithFixedSizeThenUpdateWithDataShouldNotRaiseErrorWhenBufferStorageIsDynamic()
    {
        // Arrange
        var buffer = GL.CreateBuffer();
        GL.NamedBufferStorage(buffer, 0x1000, nint.Zero, GL.BufferStorageMask.DynamicStorageBit);

        // Act
        var data = new BufferData();
        GL.NamedBufferSubData(buffer, 0, data);

        // Assert
        _dummyWindow.ErrorMessages.Should().HaveCount(0);
        GL.DeleteBuffer(buffer);
    }
}