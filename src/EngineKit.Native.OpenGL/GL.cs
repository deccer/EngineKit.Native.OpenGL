using System;
using System.Runtime.InteropServices;
using EngineKit.Mathematics;
// ReSharper disable InconsistentNaming

namespace EngineKit.Native.OpenGL;

public static unsafe partial class GL
{
    public delegate void GLDebugProc(
        DebugSource source,
        DebugType type,
        uint id,
        DebugSeverity severity,
        int length,
        IntPtr message,
        IntPtr userParam);

    public static unsafe string GetString(StringName stringName)
    {
        var result = _glGetStringDelegate(stringName);
        return (result == null
            ? string.Empty
            : Marshal.PtrToStringAnsi((IntPtr)result)) ?? string.Empty;
    }

    public static void BindFramebuffer(FramebufferTarget framebufferTarget, uint framebuffer)
    {
        _glBindFramebufferDelegate(framebufferTarget, framebuffer);
    }

    public static void BindProgramPipeline(uint pipeline)
    {
        _glBindProgramPipelineDelegate(pipeline);
    }

    public static void BlendColor(float red, float green, float blue, float alpha)
    {
        _glBlendColorDelegate(red, green, blue, alpha);
    }

    public static void BlendEquationSeparatei(
        uint buffer,
        BlendOperation modeRgb,
        BlendOperation modeAlpha)
    {
        _glBlendEquationSeparateiDelegate(buffer, modeRgb, modeAlpha);
    }

    public static void BlendFuncSeparatei(
        uint buffer,
        BlendFactor sourceRgb,
        BlendFactor destinationRgb,
        BlendFactor sourceAlpha,
        BlendFactor destinationAlpha)
    {
        _glBlendFuncSeparateiDelegate(
            buffer,
            sourceRgb,
            destinationRgb,
            sourceAlpha,
            destinationAlpha);
    }

    public static void BindBuffer(BufferTarget bufferTarget, uint id)
    {
        _glBindBufferDelegate(bufferTarget, id);
    }

    public static void BindBufferBase(BufferTarget bufferTarget, uint slot, uint id)
    {
        _glBindBufferBaseDelegate(bufferTarget, slot, id);
    }

    public static void BindVertexArray(uint vertexArray)
    {
        _glBindVertexArrayDelegate(vertexArray);
    }

    public static void Clear(ClearBufferMask clearBufferMask)
    {
        _glClearDelegate(clearBufferMask);
    }

    public static void ClearColor(float red, float green, float blue, float alpha)
    {
        _glClearColorDelegate(red, green, blue, alpha);
    }

    public static void ClearDepth(float depth)
    {
        _glClearDepthfDelegate(depth);
    }

    public static void ClearNamedFramebuffer(uint framebuffer, Buffer buffer, int drawBuffer, float depth, int stencil)
    {
        _glClearNamedFramebufferfiDelegate(framebuffer, buffer, drawBuffer, depth, stencil);
    }

    public static void ClearNamedFramebuffer(uint framebuffer, Buffer buffer, int drawBuffer, in float value)
    {
        fixed (float* valuePtr = &value)
        {
            _glClearNamedFramebufferfvDelegate(framebuffer, buffer, drawBuffer, valuePtr);
        }
    }

    public static void ClearNamedFramebuffer(uint framebuffer, Buffer buffer, int drawBuffer, in int value)
    {
        fixed (int* valuePtr = &value)
        {
            _glClearNamedFramebufferivDelegate(framebuffer, buffer, drawBuffer, valuePtr);
        }
    }

    public static void ClearNamedFramebuffer(uint framebuffer, Buffer buffer, int drawBuffer, in uint value)
    {
        fixed (uint* valuePtr = &value)
        {
            _glClearNamedFramebufferuivDelegate(framebuffer, buffer, drawBuffer, valuePtr);
        }
    }

    public static void ClearStencil(int stencil)
    {
        _glClearStencilDelegate(stencil);
    }

    public static void ColorMask(
        bool red,
        bool green,
        bool blue,
        bool alpha)
    {
        var redChannel = (byte)(red ? 1 : 0);
        var greenChannel = (byte)(green ? 1 : 0);
        var blueChannel = (byte)(blue ? 1 : 0);
        var alphaChannel = (byte)(alpha ? 1 : 0);
        _glColorMaskDelegate(
            redChannel,
            greenChannel,
            blueChannel,
            alphaChannel);
    }

    public static void ColorMaski(
        uint framebuffer,
        bool red,
        bool green,
        bool blue,
        bool alpha)
    {
        var redChannel = (byte)(red ? 1 : 0);
        var greenChannel = (byte)(green ? 1 : 0);
        var blueChannel = (byte)(blue ? 1 : 0);
        var alphaChannel = (byte)(alpha ? 1 : 0);

        _glColorMaskiDelegate(
            framebuffer,
            redChannel,
            greenChannel,
            blueChannel,
            alphaChannel);
    }

    public static uint CreateBuffer()
    {
        uint buffer;
        _glCreateBuffersDelegate(1, &buffer);
        return buffer;
    }

    public static uint CreateFramebuffer()
    {
        uint framebuffer;
        _glCreateFramebuffersDelegate(1, &framebuffer);
        return framebuffer;
    }

    public static uint CreateShaderProgram(ShaderType shaderType, string shaderSource)
    {
        var shaderSourcePtr = Marshal.StringToHGlobalAnsi(shaderSource);
        var programId = _glCreateShaderProgramvDelegate(shaderType, 1, (byte**)&shaderSourcePtr);
        Marshal.FreeHGlobal(shaderSourcePtr);
        return programId;
    }

    public static uint CreateProgramPipeline()
    {
        uint programPipelineId;
        _glCreateProgramPipelinesDelegate(1, &programPipelineId);
        return programPipelineId;
    }

    public static uint CreateVertexArray()
    {
        uint vertexArray;
        _glCreateVertexArraysDelegate(1, &vertexArray);
        return vertexArray;
    }

    public static uint CreateTexture(TextureTarget target)
    {
        uint texture;
        _glCreateTexturesDelegate(target, 1, &texture);
        return texture;
    }

    public static void CullFace(CullMode cullMode)
    {
        _glCullFaceDelegate(cullMode);
    }

    public static void DeleteBuffer(uint buffer)
    {
        _glDeleteBuffersDelegate(1, &buffer);
    }

    public static void DeleteFramebuffer(int framebuffer)
    {
        _glDeleteFramebuffersDelegate(1, &framebuffer);
    }

    public static void DeleteVertexArray(uint vertexArray)
    {
        _glDeleteVertexArraysDelegate(1, &vertexArray);
    }

    public static void DeleteProgram(uint shader)
    {
        _glDeleteProgramDelegate(shader);
    }

    public static void DeleteProgramPipeline(uint pipeline)
    {
        _glDeleteProgramPipelineDelegate(pipeline);
    }

    public static void DeleteTexture(uint texture)
    {
        _glDeleteTexturesDelegate(1, &texture);
    }

    public static void DepthFunc(CompareOperation compareOperation)
    {
        _glDepthFuncDelegate(compareOperation);
    }

    public static void DepthMask(bool depth)
    {
        _glDepthMaskDelegate(depth ? (byte)1 : (byte)0);
    }

    public static void DepthRange(float minDepth, float maxDepth)
    {
        _glDepthRangeDelegate(minDepth, maxDepth);
    }

    public static void Disable(EnableType enableType)
    {
        _glDisableDelegate(enableType);
    }

    public static void DisableVertexArrayAttrib(uint vertexArray, uint index)
    {
        _glDisableVertexArrayAttribDelegate(vertexArray, index);
    }

    public static void DrawArrays(
        PrimitiveType primitiveType,
        int firstVertex,
        uint vertexCount)
    {
        _glDrawArraysDelegate(primitiveType, firstVertex, vertexCount);
    }

    public static void DrawElements(
        PrimitiveType primitiveType,
        int elementCount,
        IndexElementType elementType,
        nint offset)
    {
        var indices = (void*)offset;
        _glDrawElementsDelegate(
            primitiveType,
            elementCount,
            elementType,
            indices);
    }

    public static void DrawElementsIndirect(
        PrimitiveType primitiveType,
        IndexElementType indexElementType,
        IntPtr indirect)
    {
        var indirectPtr = (void*)indirect;
        _glDrawElementsIndirectDelegate(primitiveType, indexElementType, indirectPtr);
    }

    public static void DrawElementsIndirect<TIndirect>(
        PrimitiveType primitiveType,
        IndexElementType indexElementType,
        in TIndirect indirect)
        where TIndirect : unmanaged
    {
        fixed (void* indirectPtr = &indirect)
        {
            _glDrawElementsIndirectDelegate(primitiveType, indexElementType, indirectPtr);
        }
    }

    public static void DrawElementsBaseVertex(
        PrimitiveType primitiveType,
        int elementCount,
        IndexElementType elementsType,
        int indices,
        int baseVertex)
    {
        _glDrawElementsBaseVertexDelegate(
            primitiveType,
            elementCount,
            elementsType,
            indices,
            baseVertex);
    }

    public static void DrawElements(
        PrimitiveType primitiveType,
        int firstVertex,
        uint vertexCount)
    {
        _glDrawArraysDelegate(
            primitiveType,
            firstVertex,
            vertexCount);
    }

    public static void DrawArraysInstancedBaseInstance(
        PrimitiveType primitiveType,
        int firstVertex,
        int vertexCount,
        int instanceCount,
        uint firstInstance)
    {
        _glDrawArraysInstancedBaseInstanceDelegate(
            primitiveType,
            firstVertex,
            vertexCount,
            instanceCount,
            firstInstance);
    }

    public static void PushDebugGroup(string message)
    {
        if (string.IsNullOrEmpty(message))
        {
            return;
        }

        var messagePtr = Marshal.StringToCoTaskMemUTF8(message);
        _glPushDebugGroupDelegate(DebugSource.Application, 0, message.Length, (byte*)messagePtr);
        Marshal.FreeCoTaskMem(messagePtr);
    }

    public static void PopDebugGroup()
    {
        _glPopDebugGroupDelegate();
    }

    public static void Enable(EnableType enableType)
    {
        _glEnableDelegate(enableType);
    }

    public static void EnableWhen(EnableType enableType, bool enabled)
    {
        if (enabled)
        {
            _glEnableDelegate(enableType);
        }
        else
        {
            _glDisableDelegate(enableType);
        }
    }

    public static void EnableVertexArrayAttrib(uint vertexArray, uint index)
    {
        _glEnableVertexArrayAttribDelegate(vertexArray, index);
    }

    public static void FrontFace(FaceWinding faceWinding)
    {
        _glFrontFaceDelegate(faceWinding);
    }

    public static uint GenTexture()
    {
        uint textureId;
        _glGenTexturesDelegate(1, &textureId);
        return textureId;
    }

    public static int GetProgram(uint programId, ProgramProperty programProperty)
    {
        int values;
        _glGetProgramivDelegate(programId, programProperty, &values);
        return values;
    }

    public static string GetProgramInfoLog(uint programId, int bufferSize, ref int length)
    {
        string infoLog;
        fixed (int* lengthPtr = &length)
        {
            var infoLogPtr = Marshal.AllocCoTaskMem(bufferSize);
            _glGetProgramInfoLogDelegate(programId, (uint)bufferSize, lengthPtr, infoLogPtr);
            infoLog = Marshal.PtrToStringUTF8(infoLogPtr)!;
            Marshal.FreeCoTaskMem(infoLogPtr);
        }

        return infoLog;
    }

    public static void LineWidth(float lineWidth)
    {
        _glLineWidthDelegate(lineWidth);
    }

    public static void LogicOp(LogicOperation logicOperation)
    {
        _glLogicOpDelegate(logicOperation);
    }

    public static void NamedBufferStorage(
        uint buffer,
        long size,
        IntPtr data,
        BufferStorageMask bufferStorageMask)
    {
        var dataPtr = (void*)data;
        NamedBufferStorage(buffer, size, dataPtr, bufferStorageMask);
    }

    public static void NamedBufferStorage<TData>(
        uint buffer,
        in TData data,
        BufferStorageMask bufferStorageMask)
        where TData : unmanaged
    {
        var size = (long)sizeof(TData);
        fixed (void* dataPtr = &data)
        {
            NamedBufferStorage(buffer, size, dataPtr, bufferStorageMask);
        }
    }

    public static void NamedBufferStorage<TData>(
        uint buffer,
        TData[] data,
        BufferStorageMask bufferStorageMask)
        where TData : unmanaged
    {
        var size = (long)(data.Length * sizeof(TData));
        fixed (void* dataPtr = data)
        {
            NamedBufferStorage(buffer, size, dataPtr, bufferStorageMask);
        }
    }

    public static void NamedBufferSubData<TData>(
        uint buffer,
        int offset,
        TData[] data)
        where TData : unmanaged
    {
        var size = (long)(data.Length * sizeof(TData));
        fixed (void* dataPtr = data)
        {
            NamedBufferSubData(buffer, offset, size, dataPtr);
        }
    }

    public static void NamedBufferSubData<TData>(
        uint buffer,
        int offset,
        in TData data)
        where TData : unmanaged
    {
        var size = (long)sizeof(TData);
        fixed (void* dataPtr = &data)
        {
            NamedBufferSubData(buffer, offset, size, dataPtr);
        }
    }

    public static void NamedBufferSubData(
        uint buffer,
        int offset,
        long size,
        IntPtr data)
    {
        NamedBufferSubData(buffer, offset, size, (void*)data);
    }

    public static unsafe void NamedBufferData(
        uint buffer,
        uint size,
        IntPtr data,
        BufferUsage usage)
    {
        var dataPtr = (void*)data;
        NamedBufferData(buffer, size, dataPtr, usage);
    }

    public static unsafe void NamedBufferData<TData>(
        uint buffer,
        Span<TData> data,
        BufferUsage usage)
        where TData : unmanaged
    {
        var size = (uint)(data.Length * sizeof(TData));
        fixed (void* dataPtr = data)
        {
            NamedBufferData(buffer, size, dataPtr, usage);
        }
    }

    public static unsafe void NamedBufferData<TData>(
        uint buffer,
        TData[] data,
        BufferUsage usage)
        where TData : unmanaged
    {
        var size = (uint)(data.Length * sizeof(TData));
        fixed (void* dataPtr = data)
        {
            NamedBufferData(buffer, size, dataPtr, usage);
        }
    }

    private static void NamedBufferStorage(
        uint buffer,
        long size,
        void* dataPtr,
        BufferStorageMask bufferStorageMask)
    {
        _glNamedBufferStorageDelegate(buffer, size, dataPtr, bufferStorageMask);
    }

    private static void NamedBufferData(
        uint buffer,
        uint size,
        void* dataPtr,
        BufferUsage bufferUsage)
    {
        _glNamedBufferDataDelegate(buffer, size, dataPtr, bufferUsage);
    }

    private static void NamedBufferSubData(
        uint buffer,
        int offset,
        long size,
        void* dataPtr)
    {
        _glNamedBufferSubDataDelegate(buffer, offset, size, dataPtr);
    }

    public static void ObjectLabel(ObjectIdentifier identifier, uint name, string label)
    {
        var labelLength = label.Length;
        if (labelLength > 0)
        {
            var labelPtr = Marshal.StringToHGlobalAnsi(label);
            _glObjectLabelDelegate(identifier, name, labelLength, (byte*)labelPtr);
            Marshal.FreeHGlobal(labelPtr);
        }
    }

    public static void PointSize(float pointSize)
    {
        _glPointSizeDelegate(pointSize);
    }

    public static void PolygonMode(
        PolygonModeType polygonMode,
        FillMode fillMode)
    {
        _glPolygonModeDelegate(polygonMode, fillMode);
    }

    public static void PolygonOffset(
        float factor,
        float units)
    {
        _glPolygonOffsetDelegate(factor, units);
    }

    public static void ProgramParameter(
        uint programId,
        ProgramParameterType programParameterType,
        int value)
    {
        _glProgramParameteriDelegate(programId, programParameterType, value);
    }

    public static void StencilMask(bool stencil)
    {
        _glStencilMaskDelegate((byte)(stencil ? 1 : 0));
    }

    public static void TextureView(
        uint textureViewId,
        TextureTarget target,
        uint textureId,
        SizedInternalFormat internalFormat,
        uint minLevel,
        uint numLevels,
        uint minLayer,
        uint numLayers)
    {
        _glTextureViewDelegate(
            textureViewId,
            target,
            textureId,
            internalFormat,
            minLevel,
            numLevels,
            minLayer,
            numLayers);
    }

    public static void UseProgram(uint programId)
    {
        _glUseProgramDelegate(programId);
    }

    public static void UseProgramStages(
        uint programPipelineId,
        UseProgramStageMask useProgramStageMask,
        uint programId)
    {
        _glUseProgramStagesDelegate(programPipelineId, useProgramStageMask, programId);
    }

    public static void VertexArrayAttribBinding(
        uint vertexArray,
        uint attributeIndex,
        uint bindingIndex)
    {
        _glVertexArrayAttribBindingDelegate(vertexArray, attributeIndex, bindingIndex);
    }

    public static void VertexArrayAttribFormat(
        uint vertexArray,
        uint attributeIndex,
        int dataTypeSize,
        DataType dataType,
        bool isNormalized,
        uint relativeOffset)
    {
        _glVertexArrayAttribFormatDelegate(
            vertexArray,
            attributeIndex,
            dataTypeSize,
            dataType,
            (byte)(isNormalized ? 1 : 0),
            relativeOffset);
    }

    public static void VertexArrayAttribIFormat(
        uint vertexArray,
        uint attributeIndex,
        int dataTypeSize,
        DataType dataType,
        uint relativeOffset)
    {
        _glVertexArrayAttribIFormatDelegate(
            vertexArray,
            attributeIndex,
            dataTypeSize,
            dataType,
            relativeOffset);
    }

    public static void Viewport(Viewport viewport)
    {
        _glViewportDelegate(
            viewport.X,
            viewport.Y,
            viewport.Width,
            viewport.Height);
    }

    public static void Scissor(Viewport viewport)
    {
        _glScissorDelegate(
            viewport.X,
            viewport.Y,
            viewport.Width,
            viewport.Height);
    }

    public static void Scissor(int x, int y, int width, int height)
    {
        _glScissorDelegate(
            x,
            y,
            width,
            height);
    }


    public static void GenerateTextureMipmap(uint texture)
    {
        _generateTextureMipmapDelegate(texture);
    }

    public static void TextureSubImage1D(
        uint texture,
        int level,
        int xOffset,
        int width,
        PixelFormat format,
        DataType type,
        void* pixelPtr)
    {
        _glTextureSubImage1DDelegate(
            texture,
            level,
            xOffset,
            width,
            format,
            type,
            pixelPtr);
    }

    public static void TextureSubImage1D<TPixel>(
        uint texture,
        int level,
        int xOffset,
        int width,
        PixelFormat format,
        DataType type,
        in TPixel pixels) where TPixel : unmanaged
    {
        fixed (void* pixelPtr = &pixels)
        {
            _glTextureSubImage1DDelegate(
                texture,
                level,
                xOffset,
                width,
                format,
                type,
                pixelPtr);
        }
    }

    public static void TextureSubImage2D(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int width,
        int height,
        PixelFormat format,
        DataType type,
        void* pixelPtr)
    {
        _glTextureSubImage2DDelegate(
            texture,
            level,
            xOffset,
            yOffset,
            width,
            height,
            format,
            type,
            pixelPtr);
    }

    public static void TextureSubImage2D<TPixel>(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int width,
        int height,
        PixelFormat format,
        DataType type,
        in TPixel pixels) where TPixel : unmanaged
    {
        fixed (void* pixelPtr = &pixels)
        {
            _glTextureSubImage2DDelegate(
                texture,
                level,
                xOffset,
                yOffset,
                width,
                height,
                format,
                type,
                pixelPtr);
        }
    }

    public static void TextureSubImage2D(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int width,
        int height,
        PixelFormat format,
        DataType type,
        IntPtr pixelPtr)
    {
        _glTextureSubImage2DDelegate(
            texture,
            level,
            xOffset,
            yOffset,
            width,
            height,
            format,
            type,
            (void*)pixelPtr);
    }

    public static void TextureSubImage3D(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int zOffset,
        int width,
        int height,
        int depth,
        PixelFormat format,
        DataType type,
        void* pixelPtr)
    {
        _glTextureSubImage3DDelegate(
            texture,
            level,
            xOffset,
            yOffset,
            zOffset,
            width,
            height,
            depth,
            format,
            type,
            pixelPtr);
    }

    public static void TextureSubImage3D<TPixel>(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int zOffset,
        int width,
        int height,
        int depth,
        PixelFormat format,
        DataType type,
        in TPixel pixels) where TPixel : unmanaged
    {
        fixed (void* pixelPtr = &pixels)
        {
            _glTextureSubImage3DDelegate(
                texture,
                level,
                xOffset,
                yOffset,
                zOffset,
                width,
                height,
                depth,
                format,
                type,
                pixelPtr);
        }
    }

    public static void NamedFramebufferTexture(
        uint framebuffer,
        FramebufferAttachment attachment,
        uint texture,
        int level)
    {
        _glNamedFramebufferTextureDelegate(framebuffer, attachment, texture, level);
    }

    public static void NamedFramebufferDrawBuffers(
        uint framebuffer,
        params DrawBuffer[] drawBuffers)
    {
        fixed (DrawBuffer* drawBuffersPtr = drawBuffers)
        {
            _glNamedFramebufferDrawBuffersDelegate(framebuffer, (uint)drawBuffers.Length, drawBuffersPtr);
        }
    }

    public static void DebugMessageCallback(GLDebugProc callback, IntPtr userParam)
    {
        var userParamPtr = (void*)userParam;
        var callbackPtr = Marshal.GetFunctionPointerForDelegate(callback);
        _glDebugMessageCallbackDelegate(callbackPtr, userParamPtr);
    }

    public static void VertexArrayVertexBuffer(
        uint vao,
        uint bindingIndex,
        uint buffer,
        IntPtr offset,
        int stride)
    {
        _glVertexArrayVertexBufferDelegate(
            vao,
            bindingIndex,
            buffer,
            offset,
            stride);
    }

    public static void VertexArrayElementBuffer(
        uint vao,
        uint buffer)
    {
        _glVertexArrayElementBufferDelegate(vao, buffer);
    }

    public static void MultiDrawElementsIndirect(
        PrimitiveType primitiveType,
        IndexElementType indexElementType,
        IntPtr indirectData,
        int indirectDrawCount,
        int indirectDataStride)
    {
        var indirectDataPtr = (void*)indirectData;
        _glMultiDrawElementsIndirectDelegate(
            primitiveType,
            indexElementType,
            indirectDataPtr,
            indirectDrawCount,
            indirectDataStride);
    }

    public static void Finish()
    {
        _glFinishDelegate();
    }

    public static ulong GetTextureHandle(uint textureId)
    {
        return _glGetTextureHandleARBDelegate(textureId);
    }

    public static ulong GetTextureSamplerHandle(
        uint textureId,
        uint samplerId)
    {
        return _glGetTextureSamplerHandleARBDelegate(textureId, samplerId);
    }

    public static void MakeTextureHandleResident(ulong textureHandle)
    {
        _glMakeTextureHandleResidentARBDelegate(textureHandle);
    }

    public static void MakeTextureHandleNonResident(ulong textureHandle)
    {
        _glMakeTextureHandleNonResidentARBDelegate(textureHandle);
    }

    public static void BindTextureUnit(uint unit, uint texture)
    {
        _glBindTextureUnitDelegate(unit, texture);
    }

    public static void TextureStorage1D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width)
    {
        _glTextureStorage1DDelegate(
            texture,
            levels,
            internalFormat,
            width);
    }

    public static void TextureStorage2D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width,
        int height)
    {
        _glTextureStorage2DDelegate(
            texture,
            levels,
            internalFormat,
            width,
            height);
    }

    public static void TextureStorage3D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width,
        int height,
        int depth)
    {
        _glTextureStorage3DDelegate(
            texture,
            levels,
            internalFormat,
            width,
            height,
            depth);
    }

    public static uint CreateSampler()
    {
        uint sampler;
        _glCreateSamplersDelegate(1, &sampler);
        return sampler;
    }

    public static void SamplerParameter(
        uint sampler,
        SamplerParameterI parameterName,
        int parameterValue)
    {
        _glSamplerParameteriDelegate(sampler, parameterName, parameterValue);
    }

    public static void SamplerParameter(
        uint sampler,
        SamplerParameterF parameterName,
        float parameterValue)
    {
        _glSamplerParameterfDelegate(sampler, parameterName, parameterValue);
    }

    public static void BindSampler(
        uint unit,
        uint samplerId)
    {
        _glBindSamplerDelegate(unit, samplerId);
    }

    public static void BlendEquation(BlendEquationMode blendEquationMode)
    {
        _glBlendEquationDelegate(blendEquationMode);
    }

    public static void BlendFunc(BlendFactor sourceBlendFactor, BlendFactor destinationBlendFactor)
    {
        _glBlendFuncDelegate(sourceBlendFactor, destinationBlendFactor);
    }

    public static void ActiveTexture(TextureUnit textureUnit)
    {
        _glActiveTextureDelegate(textureUnit);
    }

    public static void BindTexture(TextureTarget textureTarget, uint textureId)
    {
        _glBindTextureDelegate(textureTarget, textureId);
    }

    public static void BlitNamedFramebuffer(
        uint readFramebuffer,
        uint drawFramebuffer,
        int srcX0,
        int srcY0,
        int srcX1,
        int srcY1,
        int dstX0,
        int dstY0,
        int dstX1,
        int dstY1,
        ClearBufferMask mask,
        BlitFramebufferFilter filter)
    {
        _glBlitNamedFramebufferDelegate(
            readFramebuffer,
            drawFramebuffer,
            srcX0,
            srcY0,
            srcX1,
            srcY1,
            dstX0,
            dstY0,
            dstX1,
            dstY1,
            mask,
            filter);
    }
}