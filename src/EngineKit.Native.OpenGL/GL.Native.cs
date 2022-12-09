﻿using System;
using System.Runtime.InteropServices;

// ReSharper disable InconsistentNaming
namespace EngineKit.Native.OpenGL;

public static unsafe partial class GL
{
    private static delegate* unmanaged<StringName, byte*> _glGetStringDelegate = &glGetString;
    private static delegate* unmanaged<BufferTarget, uint, void> _glBindBufferDelegate = &glBindBuffer;
    private static delegate* unmanaged<BufferTarget, uint, uint, void> _glBindBufferBaseDelegate = &glBindBufferBase;
    private static delegate* unmanaged<FramebufferTarget, uint, void> _glBindFramebufferDelegate = &glBindFramebuffer;
    private static delegate* unmanaged<uint, void> _glBindProgramPipelineDelegate = &glBindProgramPipeline;
    private static delegate* unmanaged<uint, void> _glBindVertexArrayDelegate = &glBindVertexArray;
    private static delegate* unmanaged<TextureTarget, uint, void> _glBindTextureDelegate = &glBindTexture;
    private static delegate* unmanaged<TextureUnit, void> _glActiveTextureDelegate = &glActiveTexture;
    private static delegate* unmanaged<float, float, float, float, void> _glBlendColorDelegate = &glBlendColor;
    private static delegate* unmanaged<void> _glFinishDelegate = &glFinish;

    private static delegate* unmanaged<QueryTarget, int, void> _glBeginQueryDelegate = &glBeginQuery;
    private static delegate* unmanaged<QueryTarget, void> _glEndQueryDelegate = &glEndQuery;
    private static delegate* unmanaged<QueryTarget, int, int*, void> _glCreateQueriesDelegate = &glCreateQueries;
    private static delegate* unmanaged<int, QueryObjectParameterName, uint*, void> _glGetQueryObjectuivDelegate = &glGetQueryObjectuiv;

    private static delegate* unmanaged<BlendEquationMode, void> _glBlendEquationDelegate = &glBlendEquation;
    private static delegate* unmanaged<BlendFactor, BlendFactor, void> _glBlendFuncDelegate = &glBlendFunc;

    private static delegate* unmanaged<uint, BlendOperation, BlendOperation, void> _glBlendEquationSeparateiDelegate =
        &glBlendEquationSeparatei;

    private static delegate* unmanaged<uint, BlendFactor, BlendFactor, BlendFactor, BlendFactor, void>
        _glBlendFuncSeparateiDelegate = &glBlendFuncSeparatei;

    private static delegate* unmanaged<ClearBufferMask, void> _glClearDelegate = &glClear;
    private static delegate* unmanaged<float, float, float, float, void> _glClearColorDelegate = &glClearColor;
    private static delegate* unmanaged<float, void> _glClearDepthfDelegate = &glClearDepthf;
    private static delegate* unmanaged<int, void> _glClearStencilDelegate = &glClearStencil;

    private static delegate* unmanaged<int, Buffer, int, float, int, void> _glClearNamedFramebufferfiDelegate =
        &glClearNamedFramebufferfi;

    private static delegate* unmanaged<int, Buffer, int, float*, void> _glClearNamedFramebufferfvDelegate =
        &glClearNamedFramebufferfv;

    private static delegate* unmanaged<int, Buffer, int, int*, void> _glClearNamedFramebufferivDelegate =
        &glClearNamedFramebufferiv;

    private static delegate* unmanaged<int, Buffer, int, uint*, void> _glClearNamedFramebufferuivDelegate =
        &glClearNamedFramebufferuiv;

    private static delegate* unmanaged<byte, byte, byte, byte, void> _glColorMaskDelegate = &glColorMask;
    private static delegate* unmanaged<uint, byte, byte, byte, byte, void> _glColorMaskiDelegate = &glColorMaski;

    private static delegate* unmanaged<int, int*, void> _glCreateBuffersDelegate = &glCreateBuffers;
    private static delegate* unmanaged<int, int*, void> _glCreateFramebuffersDelegate = &glCreateFramebuffers;

    private static delegate* unmanaged<ShaderType, int, byte**, int> _glCreateShaderProgramvDelegate =
        &glCreateShaderProgramv;

    private static delegate* unmanaged<int, int*, void> _glCreateProgramPipelinesDelegate = &glCreateProgramPipelines;
    private static delegate* unmanaged<int, int*, void> _glCreateVertexArraysDelegate = &glCreateVertexArrays;
    private static delegate* unmanaged<TextureTarget, int, int*, void> _glCreateTexturesDelegate = &glCreateTextures;

    private static delegate* unmanaged<CullMode, void> _glCullFaceDelegate = &glCullFace;

    private static delegate* unmanaged<int, int*, void> _glDeleteBuffersDelegate = &glDeleteBuffers;
    private static delegate* unmanaged<int, int*, void> _glDeleteFramebuffersDelegate = &glDeleteFramebuffers;
    private static delegate* unmanaged<int, int*, void> _glDeleteVertexArraysDelegate = &glDeleteVertexArrays;
    private static delegate* unmanaged<int, void> _glDeleteProgramDelegate = &glDeleteProgram;
    private static delegate* unmanaged<int, int*, void> _glDeleteProgramPipelinesDelegate = &glDeleteProgramPipelines;
    private static delegate* unmanaged<int, int*, void> _glDeleteTexturesDelegate = &glDeleteTextures;
    private static delegate* unmanaged<int, int*, void> _glDeleteSamplersDelegate = &glDeleteSamplers;
    private static delegate* unmanaged<int, int*, void> _glDeleteQueriesDelegate = &glDeleteQueries;

    private static delegate* unmanaged<CompareOperation, void> _glDepthFuncDelegate = &glDepthFunc;
    private static delegate* unmanaged<byte, void> _glDepthMaskDelegate = &glDepthMask;
    private static delegate* unmanaged<float, float, void> _glDepthRangeDelegate = &glDepthRangef;

    private static delegate* unmanaged<EnableType, void> _glDisableDelegate = &glDisable;

    private static delegate* unmanaged<uint, uint, void> _glDisableVertexArrayAttribDelegate =
        &glDisableVertexArrayAttrib;

    private static delegate* unmanaged<PrimitiveType, int, uint, void> _glDrawArraysDelegate = &glDrawArrays;

    private static delegate* unmanaged<PrimitiveType, int, int, int, uint, void>
        _glDrawArraysInstancedBaseInstanceDelegate =
            &glDrawArraysInstancedBaseInstance;

    private static delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, void> _glDrawElementsDelegate =
        &glDrawElements;

    private static delegate* unmanaged<PrimitiveType, int, IndexElementType, int, int, void>
        _glDrawElementsBaseVertexDelegate = &glDrawElementsBaseVertex;

    private static delegate* unmanaged<PrimitiveType, IndexElementType, void*, void> _glDrawElementsIndirectDelegate =
        &glDrawElementsIndirect;

    private static delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, int, void>
        _glDrawElementsInstancedDelegate = &glDrawElementsInstanced;

    private static delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, int, int, void>
        _glDrawElementsInstancedBaseVertexDelegate = &glDrawElementsInstancedBaseVertex;

    private static delegate* unmanaged<EnableType, void> _glEnableDelegate = &glEnable;

    private static delegate* unmanaged<uint, uint, void>
        _glEnableVertexArrayAttribDelegate = &glEnableVertexArrayAttrib;

    private static delegate* unmanaged<FaceWinding, void> _glFrontFaceDelegate = &glFrontFace;

    private static delegate* unmanaged<uint, uint*, void> _glGenTexturesDelegate = &glGenTextures;
    private static delegate* unmanaged<uint, ProgramProperty, int*, void> _glGetProgramivDelegate = &glGetProgramiv;

    private static delegate* unmanaged<uint, uint, int*, IntPtr, void> _glGetProgramInfoLogDelegate =
        &glGetProgramInfoLog;

    private static delegate* unmanaged<float, void> _glLineWidthDelegate = &glLineWidth;
    private static delegate* unmanaged<LogicOperation, void> _glLogicOpDelegate = &glLogicOp;

    private static delegate* unmanaged<uint, long, void*, BufferStorageMask, void> _glNamedBufferStorageDelegate =
        &glNamedBufferStorage;

    private static delegate* unmanaged<uint, uint, void*, BufferUsage, void> _glNamedBufferDataDelegate =
        &glNamedBufferData;

    private static delegate* unmanaged<uint, int, long, void*, void> _glNamedBufferSubDataDelegate =
        &glNamedBufferSubData;

    private static delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>
        _glObjectLabelDelegate = &glObjectLabel;

    private static delegate* unmanaged<float, void> _glPointSizeDelegate = &glPointSize;

    private static delegate* unmanaged<uint, ProgramParameterType, int, void> _glProgramParameteriDelegate =
        &glProgramParameteri;

    private static delegate* unmanaged<PolygonModeType, FillMode, void> _glPolygonModeDelegate = &glPolygonMode;
    private static delegate* unmanaged<float, float, void> _glPolygonOffsetDelegate = &glPolygonOffset;

    private static delegate* unmanaged<byte, void> _glStencilMaskDelegate = &glStencilMask;

    private static delegate* unmanaged<uint, TextureTarget, uint, SizedInternalFormat, uint, uint, uint, uint, void>
        _glTextureViewDelegate = &glTextureView;

    private static delegate* unmanaged<uint, void> _glUseProgramDelegate = &glUseProgram;

    private static delegate* unmanaged<uint, UseProgramStageMask, uint, void> _glUseProgramStagesDelegate =
        &glUseProgramStages;

    private static delegate* unmanaged<uint, uint, uint, void> _glVertexArrayAttribBindingDelegate =
        &glVertexArrayAttribBinding;

    private static delegate* unmanaged<uint, uint, int, DataType, byte, uint, void>
        _glVertexArrayAttribFormatDelegate = &glVertexArrayAttribFormat;

    private static delegate* unmanaged<uint, uint, int, DataType, uint, void>
        _glVertexArrayAttribIFormatDelegate = &glVertexArrayAttribIFormat;

    private static delegate* unmanaged<int, int, int, int, void> _glViewportDelegate = &glViewport;
    private static delegate* unmanaged<int, int, int, int, void> _glScissorDelegate = &glScissor;

    private static delegate* unmanaged<uint, void> _generateTextureMipmapDelegate = &glGenerateTextureMipmap;

    private static delegate* unmanaged<uint, int, int, int, PixelFormat, DataType, void*, void>
        _glTextureSubImage1DDelegate = &glTextureSubImage1D;

    private static delegate* unmanaged<uint, int, int, int, int, int, PixelFormat, DataType, void*, void>
        _glTextureSubImage2DDelegate = &glTextureSubImage2D;

    private static delegate* unmanaged<uint, int, int, int, int, int, int, int, PixelFormat, DataType, void*, void>
        _glTextureSubImage3DDelegate = &glTextureSubImage3D;

    private static delegate* unmanaged<uint, FramebufferAttachment, uint, int, void>
        _glNamedFramebufferTextureDelegate = &glNamedFramebufferTexture;

    private static delegate* unmanaged<uint, uint, DrawBuffer*, void> _glNamedFramebufferDrawBuffersDelegate =
        &glNamedFramebufferDrawBuffers;

    private static delegate* unmanaged<IntPtr, void*, void> _glDebugMessageCallbackDelegate = &glDebugMessageCallback;

    private static delegate* unmanaged<uint, uint, uint, IntPtr, int, void> _glVertexArrayVertexBufferDelegate =
        &glVertexArrayVertexBuffer;

    private static delegate* unmanaged<uint, uint, void> _glVertexArrayElementBufferDelegate =
        &glVertexArrayElementBuffer;

    private static delegate* unmanaged<DebugSource, uint, int, byte*, void> _glPushDebugGroupDelegate =
        &glPushDebugGroup;

    private static delegate* unmanaged<void> _glPopDebugGroupDelegate = &glPopDebugGroup;

    private static delegate* unmanaged<PrimitiveType, IndexElementType, void*, int, int, void>
        _glMultiDrawElementsIndirectDelegate = &glMultiDrawElementsIndirect;

    private static delegate* unmanaged<uint, ulong> _glGetTextureHandleARBDelegate = &glGetTextureHandleARB;

    private static delegate* unmanaged<uint, uint, ulong> _glGetTextureSamplerHandleARBDelegate =
        &glGetTextureSamplerHandleARB;

    private static delegate* unmanaged<ulong, void> _glMakeTextureHandleResidentARBDelegate =
        &glMakeTextureHandleResidentARB;

    private static delegate* unmanaged<ulong, void> _glMakeTextureHandleNonResidentARBDelegate =
        &glMakeTextureHandleNonResidentARB;

    private static delegate* unmanaged<uint, uint, void> _glBindTextureUnitDelegate = &glBindTextureUnit;

    private static delegate* unmanaged<uint, uint, SizedInternalFormat, int, void> _glTextureStorage1DDelegate =
        &glTextureStorage1D;

    private static delegate* unmanaged<uint, uint, SizedInternalFormat, int, int, void> _glTextureStorage2DDelegate =
        &glTextureStorage2D;

    private static delegate* unmanaged<uint, uint, SizedInternalFormat, int, int, int, void>
        _glTextureStorage3DDelegate = &glTextureStorage3D;

    private static delegate* unmanaged<int, int*, void> _glCreateSamplersDelegate = &glCreateSamplers;

    private static delegate* unmanaged<uint, SamplerParameterI, int, void> _glSamplerParameteriDelegate =
        &glSamplerParameteri;

    private static delegate* unmanaged<uint, SamplerParameterF, float, void> _glSamplerParameterfDelegate =
        &glSamplerParameterf;

    private static delegate* unmanaged<uint, SamplerParameterF, float*, void> _glSamplerParameterfvDelegate =
        &glSamplerParameterfv;

    private static delegate* unmanaged<uint, SamplerParameterI, int*, void> _glSamplerParameterivDelegate =
        &glSamplerParameteriv;

    private static delegate* unmanaged<uint, uint, void> _glBindSamplerDelegate = &glBindSampler;

    private static delegate* unmanaged<uint, uint, int, int, int, int, int, int, int, int, ClearBufferMask,
        BlitFramebufferFilter, void> _glBlitNamedFramebufferDelegate = &glBlitNamedFramebuffer;

    private static delegate* unmanaged<MemoryBarrierMask, void> _glMemoryBarrierDelegate = &glMemoryBarrier;

    private static delegate* unmanaged<int, TextureParameterName, int, void> _glTextureParameteriDelegate = &glTextureParameteri;
    private static delegate* unmanaged<int, TextureParameterName, float, void> _glTextureParameterfDelegate = &glTextureParameterf;

    [UnmanagedCallersOnly]
    private static void glTextureParameteri(int texture, TextureParameterName textureParameterName, int param)
    {
        _glTextureParameteriDelegate = (delegate* unmanaged<int, TextureParameterName, int, void>)Glfw.Glfw.GetProcAddress(nameof(glTextureParameteri));
        _glTextureParameteriDelegate(texture, textureParameterName, param);
    }

    [UnmanagedCallersOnly]
    private static void glTextureParameterf(int texture, TextureParameterName textureParameterName, float param)
    {
        _glTextureParameterfDelegate = (delegate* unmanaged<int, TextureParameterName, float, void>)Glfw.Glfw.GetProcAddress(nameof(glTextureParameterf));
        _glTextureParameterfDelegate(texture, textureParameterName, param);
    }

    private static delegate* unmanaged<uint, int, int, byte, int, MemoryAccess, SizedInternalFormat, void>
        _glBindImageTextureDelegate = &glBindImageTexture;
    private static delegate* unmanaged<uint, int, int*, void> _glBindImageTexturesDelegate = &glBindImageTextures;

    private static delegate* unmanaged<uint, uint, uint, void> _glDispatchComputeDelegate = &glDispatchCompute;
    private static delegate* unmanaged<IntPtr, void> _glDispatchComputeIndirectDelegate = &glDispatchComputeIndirect;

    [UnmanagedCallersOnly]
    private static void glGenerateTextureMipmap(uint texture)
    {
        _generateTextureMipmapDelegate =
            (delegate* unmanaged<uint, void>)Glfw.Glfw.GetProcAddress(nameof(glGenerateTextureMipmap));
        _generateTextureMipmapDelegate(texture);
    }

    [UnmanagedCallersOnly]
    private static void glBindBuffer(BufferTarget bufferTarget, uint id)
    {
        _glBindBufferDelegate =
            (delegate* unmanaged<BufferTarget, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindBuffer));
        _glBindBufferDelegate(bufferTarget, id);
    }

    [UnmanagedCallersOnly]
    private static void glBindBufferBase(BufferTarget bufferTarget, uint slot, uint id)
    {
        _glBindBufferBaseDelegate =
            (delegate* unmanaged<BufferTarget, uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindBufferBase));
        _glBindBufferBaseDelegate(bufferTarget, slot, id);
    }

    [UnmanagedCallersOnly]
    private static void glBindFramebuffer(
        FramebufferTarget frameBufferTarget,
        uint frameBuffer)
    {
        _glBindFramebufferDelegate =
            (delegate* unmanaged<FramebufferTarget, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindFramebuffer));
        _glBindFramebufferDelegate(frameBufferTarget, frameBuffer);
    }

    [UnmanagedCallersOnly]
    private static void glBindProgramPipeline(uint pipeline)
    {
        _glBindProgramPipelineDelegate =
            (delegate* unmanaged<uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindProgramPipeline));
        _glBindProgramPipelineDelegate(pipeline);
    }

    [UnmanagedCallersOnly]
    private static void glBindVertexArray(uint vertexArray)
    {
        _glBindVertexArrayDelegate =
            (delegate* unmanaged<uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindVertexArray));
        _glBindVertexArrayDelegate(vertexArray);
    }

    [UnmanagedCallersOnly]
    private static void glBindTexture(TextureTarget target, uint texture)
    {
        _glBindTextureDelegate =
            (delegate* unmanaged<TextureTarget, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindTexture));
        _glBindTextureDelegate(target, texture);
    }

    [UnmanagedCallersOnly]
    private static void glActiveTexture(TextureUnit texture)
    {
        _glActiveTextureDelegate =
            (delegate* unmanaged<TextureUnit, void>)Glfw.Glfw.GetProcAddress(nameof(glActiveTexture));
        _glActiveTextureDelegate(texture);
    }

    [UnmanagedCallersOnly]
    private static void glBlendColor(
        float red,
        float green,
        float blue,
        float alpha)
    {
        _glBlendColorDelegate =
            (delegate* unmanaged<float, float, float, float, void>)Glfw.Glfw.GetProcAddress(nameof(glBlendColor));
        _glBlendColorDelegate(red, green, blue, alpha);
    }

    [UnmanagedCallersOnly]
    private static void glBlendEquation(BlendEquationMode mode)
    {
        _glBlendEquationDelegate =
            (delegate* unmanaged<BlendEquationMode, void>)Glfw.Glfw.GetProcAddress(nameof(glBlendEquation));
        _glBlendEquationDelegate(mode);
    }

    [UnmanagedCallersOnly]
    private static void glBlendFunc(
        BlendFactor sourceBlendingFactor,
        BlendFactor destinationBlendingFactor)
    {
        _glBlendFuncDelegate =
            (delegate* unmanaged<BlendFactor, BlendFactor, void>)Glfw.Glfw.GetProcAddress(nameof(glBlendFunc));
        _glBlendFuncDelegate(sourceBlendingFactor, destinationBlendingFactor);
    }

    [UnmanagedCallersOnly]
    private static void glBlendEquationSeparatei(
        uint buffer,
        BlendOperation modeRgb,
        BlendOperation modeAlpha)
    {
        _glBlendEquationSeparateiDelegate =
            (delegate* unmanaged<uint, BlendOperation, BlendOperation, void>)Glfw.Glfw.GetProcAddress(
                nameof(glBlendEquationSeparatei));
        _glBlendEquationSeparateiDelegate(buffer, modeRgb, modeAlpha);
    }

    [UnmanagedCallersOnly]
    private static void glBlendFuncSeparatei(
        uint buffer,
        BlendFactor sourceRgb,
        BlendFactor destinationRgb,
        BlendFactor sourceAlpha,
        BlendFactor destinationAlpha)
    {
        _glBlendFuncSeparateiDelegate =
            (delegate* unmanaged<uint, BlendFactor, BlendFactor, BlendFactor, BlendFactor, void>)Glfw.Glfw
                .GetProcAddress(nameof(glBlendFuncSeparatei));
        _glBlendFuncSeparateiDelegate(buffer, sourceRgb, destinationRgb, sourceAlpha, destinationAlpha);
    }

    [UnmanagedCallersOnly]
    private static void glClear(ClearBufferMask clearBufferMask)
    {
        _glClearDelegate = (delegate* unmanaged<ClearBufferMask, void>)Glfw.Glfw.GetProcAddress(nameof(glClear));
        _glClearDelegate(clearBufferMask);
    }

    [UnmanagedCallersOnly]
    private static void glClearColor(
        float red,
        float green,
        float blue,
        float alpha)
    {
        _glClearColorDelegate =
            (delegate* unmanaged<float, float, float, float, void>)Glfw.Glfw.GetProcAddress(nameof(glClearColor));
        _glClearColorDelegate(red, green, blue, alpha);
    }

    [UnmanagedCallersOnly]
    private static void glClearDepthf(float depth)
    {
        _glClearDepthfDelegate = (delegate* unmanaged<float, void>)Glfw.Glfw.GetProcAddress(nameof(glClearDepthf));
        _glClearDepthfDelegate(depth);
    }

    [UnmanagedCallersOnly]
    private static void glClearNamedFramebufferfi(
        int framebuffer,
        Buffer buffer,
        int index,
        float clearDepth,
        int clearStencil)
    {
        _glClearNamedFramebufferfiDelegate =
            (delegate* unmanaged<int, Buffer, int, float, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glClearNamedFramebufferfv));
        _glClearNamedFramebufferfiDelegate(framebuffer, buffer, index, clearDepth, clearStencil);
    }

    [UnmanagedCallersOnly]
    private static void glClearNamedFramebufferfv(
        int framebuffer,
        Buffer buffer,
        int index,
        float* clearColor)
    {
        _glClearNamedFramebufferfvDelegate =
            (delegate* unmanaged<int, Buffer, int, float*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glClearNamedFramebufferfv));
        _glClearNamedFramebufferfvDelegate(framebuffer, buffer, index, clearColor);
    }

    [UnmanagedCallersOnly]
    private static void glClearNamedFramebufferiv(
        int framebuffer,
        Buffer buffer,
        int index,
        int* clearColor)
    {
        _glClearNamedFramebufferivDelegate =
            (delegate* unmanaged<int, Buffer, int, int*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glClearNamedFramebufferiv));
        _glClearNamedFramebufferivDelegate(framebuffer, buffer, index, clearColor);
    }

    [UnmanagedCallersOnly]
    private static void glClearNamedFramebufferuiv(
        int framebuffer,
        Buffer buffer,
        int index,
        uint* clearColor)
    {
        _glClearNamedFramebufferuivDelegate =
            (delegate* unmanaged<int, Buffer, int, uint*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glClearNamedFramebufferuiv));
        _glClearNamedFramebufferuivDelegate(framebuffer, buffer, index, clearColor);
    }

    [UnmanagedCallersOnly]
    private static void glClearStencil(int stencil)
    {
        _glClearStencilDelegate = (delegate* unmanaged<int, void>)Glfw.Glfw.GetProcAddress(nameof(glClearStencil));
        _glClearStencilDelegate(stencil);
    }

    [UnmanagedCallersOnly]
    private static void glColorMask(
        byte red,
        byte green,
        byte blue,
        byte alpha)
    {
        _glColorMaskDelegate =
            (delegate* unmanaged<byte, byte, byte, byte, void>)Glfw.Glfw.GetProcAddress(nameof(glColorMask));
        _glColorMaskDelegate(red, green, blue, alpha);
    }

    [UnmanagedCallersOnly]
    private static void glColorMaski(
        uint buffer,
        byte red,
        byte green,
        byte blue,
        byte alpha)
    {
        _glColorMaskiDelegate =
            (delegate* unmanaged<uint, byte, byte, byte, byte, void>)Glfw.Glfw.GetProcAddress(nameof(glColorMaski));
        _glColorMaskiDelegate(buffer, red, green, blue, alpha);
    }

    [UnmanagedCallersOnly]
    private static void glCreateBuffers(
        int count,
        int* buffers)
    {
        _glCreateBuffersDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateBuffers));
        _glCreateBuffersDelegate(count, buffers);
    }

    [UnmanagedCallersOnly]
    private static void glCreateFramebuffers(
        int count,
        int* framebuffers)
    {
        _glCreateFramebuffersDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateFramebuffers));
        _glCreateFramebuffersDelegate(count, framebuffers);
    }

    [UnmanagedCallersOnly]
    private static int glCreateShaderProgramv(
        ShaderType shaderType,
        int shaderCount,
        byte** shaderSource)
    {
        _glCreateShaderProgramvDelegate =
            (delegate* unmanaged<ShaderType, int, byte**, int>)Glfw.Glfw.GetProcAddress("glCreateShaderProgramv");
        var program = _glCreateShaderProgramvDelegate(shaderType, shaderCount, shaderSource);
        return program;
    }

    [UnmanagedCallersOnly]
    private static void glCreateProgramPipelines(
        int count,
        int* pipelineIds)
    {
        _glCreateProgramPipelinesDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateProgramPipelines));
        _glCreateProgramPipelinesDelegate(count, pipelineIds);
    }

    [UnmanagedCallersOnly]
    private static void glCreateVertexArrays(
        int count,
        int* vertexArrays)
    {
        _glCreateVertexArraysDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateVertexArrays));
        _glCreateVertexArraysDelegate(count, vertexArrays);
    }

    [UnmanagedCallersOnly]
    private static void glCullFace(CullMode cullMode)
    {
        _glCullFaceDelegate = (delegate* unmanaged<CullMode, void>)Glfw.Glfw.GetProcAddress(nameof(glCullFace));
        _glCullFaceDelegate(cullMode);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteBuffers(
        int count,
        int* buffers)
    {
        _glDeleteBuffersDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteBuffers));
        _glDeleteBuffersDelegate(count, buffers);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteFramebuffers(
        int count,
        int* framebuffers)
    {
        _glDeleteFramebuffersDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteFramebuffers));
        _glDeleteFramebuffersDelegate(count, framebuffers);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteProgram(int program)
    {
        _glDeleteProgramDelegate = (delegate* unmanaged<int, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteProgram));
        _glDeleteProgramDelegate(program);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteProgramPipelines(int count, int* pipelines)
    {
        _glDeleteProgramPipelinesDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteProgramPipelines));
        _glDeleteProgramPipelinesDelegate(count, pipelines);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteVertexArrays(
        int count,
        int* vertexArrays)
    {
        _glDeleteVertexArraysDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteVertexArrays));
        _glDeleteVertexArraysDelegate(count, vertexArrays);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteTextures(int count, int* textures)
    {
        _glDeleteTexturesDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteTextures));
        _glDeleteTexturesDelegate(count, textures);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteSamplers(int count, int* samplers)
    {
        _glDeleteSamplersDelegate = (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteSamplers));
        _glDeleteSamplersDelegate(count, samplers);
    }

    [UnmanagedCallersOnly]
    private static void glDeleteQueries(int count, int* queries)
    {
        _glDeleteQueriesDelegate = (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glDeleteQueries));
        _glDeleteQueriesDelegate(count, queries);
    }

    [UnmanagedCallersOnly]
    private static void glCreateTextures(
        TextureTarget textureTarget,
        int count,
        int* textureIds)
    {
        _glCreateTexturesDelegate =
            (delegate* unmanaged<TextureTarget, int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateTextures));
        _glCreateTexturesDelegate(textureTarget, 1, textureIds);
    }

    [UnmanagedCallersOnly]
    private static void glDepthFunc(CompareOperation compareOperation)
    {
        _glDepthFuncDelegate =
            (delegate* unmanaged<CompareOperation, void>)Glfw.Glfw.GetProcAddress(nameof(glDepthFunc));
        _glDepthFuncDelegate(compareOperation);
    }

    [UnmanagedCallersOnly]
    private static void glDepthMask(byte depth)
    {
        _glDepthMaskDelegate = (delegate* unmanaged<byte, void>)Glfw.Glfw.GetProcAddress(nameof(glDepthMask));
        _glDepthMaskDelegate(depth);
    }

    [UnmanagedCallersOnly]
    private static void glDepthRangef(
        float minDepth,
        float maxDepth)
    {
        _glDepthRangeDelegate =
            (delegate* unmanaged<float, float, void>)Glfw.Glfw.GetProcAddress(nameof(glDepthRangef));
        _glDepthRangeDelegate(minDepth, maxDepth);
    }

    [UnmanagedCallersOnly]
    private static void glDisable(EnableType enableType)
    {
        _glDisableDelegate = (delegate* unmanaged<EnableType, void>)Glfw.Glfw.GetProcAddress(nameof(glDisable));
        _glDisableDelegate(enableType);
    }

    [UnmanagedCallersOnly]
    private static void glDisableVertexArrayAttrib(
        uint vertexArray,
        uint index)
    {
        _glDisableVertexArrayAttribDelegate =
            (delegate* unmanaged<uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glDisableVertexArrayAttrib));
        _glDisableVertexArrayAttribDelegate(vertexArray, index);
    }

    [UnmanagedCallersOnly]
    private static void glDrawArrays(
        PrimitiveType primitiveType,
        int firstVertex,
        uint vertexCount)
    {
        _glDrawArraysDelegate = (delegate* unmanaged<PrimitiveType, int, uint, void>)Glfw.Glfw.GetProcAddress(
            nameof(glDrawArrays));
        _glDrawArraysDelegate(
            primitiveType,
            firstVertex,
            vertexCount);
    }

    [UnmanagedCallersOnly]
    private static void glDrawElements(
        PrimitiveType primitiveType,
        int indexCount,
        IndexElementType indexElementType,
        void* indices)
    {
        _glDrawElementsDelegate =
            (delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glDrawElements));
        _glDrawElementsDelegate(
            primitiveType,
            indexCount,
            indexElementType,
            indices);
    }

    [UnmanagedCallersOnly]
    private static void glDrawElementsBaseVertex(
        PrimitiveType mode,
        int count,
        IndexElementType type,
        int indices,
        int baseVertex)
    {
        _glDrawElementsBaseVertexDelegate =
            (delegate* unmanaged<PrimitiveType, int, IndexElementType, int, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glDrawElementsBaseVertex));
        _glDrawElementsBaseVertexDelegate(
            mode,
            count,
            type,
            indices,
            baseVertex);
    }

    [UnmanagedCallersOnly]
    private static void glDrawElementsInstanced(
        PrimitiveType primitiveType,
        int indexCount,
        IndexElementType indexElementType,
        void* indices,
        int instanceCount)
    {
        _glDrawElementsInstancedDelegate =
            (delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glDrawElementsInstanced));
        _glDrawElementsInstancedDelegate(primitiveType, indexCount, indexElementType, indices, instanceCount);
    }

    [UnmanagedCallersOnly]
    private static void glDrawElementsInstancedBaseVertex(
        PrimitiveType primitiveType,
        int elementCount,
        IndexElementType indexElementType,
        void* indices,
        int instanceCount,
        int baseVertex)
    {
        _glDrawElementsInstancedBaseVertexDelegate = (delegate* unmanaged<PrimitiveType, int, IndexElementType, void*, int, int, void>)Glfw.Glfw.GetProcAddress(
            nameof(_glDrawElementsInstancedBaseVertexDelegate));
        _glDrawElementsInstancedBaseVertexDelegate(
            primitiveType,
            elementCount,
            indexElementType,
            indices,
            instanceCount,
            baseVertex);
    }

    [UnmanagedCallersOnly]
    private static void glDrawArraysInstancedBaseInstance(
        PrimitiveType primitiveType,
        int firstVertex,
        int vertexCount,
        int instanceCount,
        uint firstInstance)
    {
        _glDrawArraysInstancedBaseInstanceDelegate =
            (delegate* unmanaged<PrimitiveType, int, int, int, uint, void>)Glfw.Glfw.GetProcAddress(
                nameof(glDrawArraysInstancedBaseInstance));
        _glDrawArraysInstancedBaseInstanceDelegate(
            primitiveType,
            firstVertex,
            vertexCount,
            instanceCount,
            firstInstance);
    }

    [UnmanagedCallersOnly]
    private static void glEnable(EnableType enableType)
    {
        _glEnableDelegate = (delegate* unmanaged<EnableType, void>)Glfw.Glfw.GetProcAddress(nameof(glEnable));
        _glEnableDelegate(enableType);
    }

    [UnmanagedCallersOnly]
    private static void glDrawElementsIndirect(
        PrimitiveType primitiveType,
        IndexElementType indexElementType,
        void* indirect)
    {
        _glDrawElementsIndirectDelegate =
            (delegate* unmanaged<PrimitiveType, IndexElementType, void*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glDrawElementsIndirect));
        _glDrawElementsIndirectDelegate(primitiveType, indexElementType, indirect);
    }

    [UnmanagedCallersOnly]
    private static void glEnableVertexArrayAttrib(
        uint vertexArray,
        uint index)
    {
        _glEnableVertexArrayAttribDelegate =
            (delegate* unmanaged<uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glEnableVertexArrayAttrib));
        _glEnableVertexArrayAttribDelegate(vertexArray, index);
    }

    [UnmanagedCallersOnly]
    private static void glFrontFace(FaceWinding faceWinding)
    {
        _glFrontFaceDelegate = (delegate* unmanaged<FaceWinding, void>)Glfw.Glfw.GetProcAddress(nameof(glFrontFace));
        _glFrontFaceDelegate(faceWinding);
    }

    [UnmanagedCallersOnly]
    private static void glGenTextures(uint count, uint* textureIds)
    {
        _glGenTexturesDelegate =
            (delegate* unmanaged<uint, uint*, void>)Glfw.Glfw.GetProcAddress(nameof(glGenTextures));
        _glGenTexturesDelegate(count, textureIds);
    }

    [UnmanagedCallersOnly]
    private static void glGetProgramiv(
        uint programId,
        ProgramProperty programProperty,
        int* values)
    {
        _glGetProgramivDelegate =
            (delegate* unmanaged<uint, ProgramProperty, int*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glGetProgramiv));
        _glGetProgramivDelegate(programId, programProperty, values);
    }

    [UnmanagedCallersOnly]
    private static void glGetProgramInfoLog(
        uint programId,
        uint bufferSize,
        int* lengthPtr,
        IntPtr infoLog)
    {
        _glGetProgramInfoLogDelegate =
            (delegate* unmanaged<uint, uint, int*, IntPtr, void>)Glfw.Glfw.GetProcAddress(nameof(glGetProgramInfoLog));
        _glGetProgramInfoLogDelegate(programId, bufferSize, lengthPtr, infoLog);
    }

    [UnmanagedCallersOnly]
    private static void glLineWidth(float lineWidth)
    {
        _glLineWidthDelegate = (delegate* unmanaged<float, void>)Glfw.Glfw.GetProcAddress(nameof(glLineWidth));
        _glLineWidthDelegate(lineWidth);
    }

    [UnmanagedCallersOnly]
    private static void glLogicOp(LogicOperation logicOperation)
    {
        _glLogicOpDelegate = (delegate* unmanaged<LogicOperation, void>)Glfw.Glfw.GetProcAddress(nameof(glLogicOp));
        _glLogicOpDelegate(logicOperation);
    }

    [UnmanagedCallersOnly]
    private static void glNamedBufferStorage(
        uint buffer,
        long size,
        void* dataPtr,
        BufferStorageMask bufferStorageMask)
    {
        _glNamedBufferStorageDelegate =
            (delegate* unmanaged<uint, long, void*, BufferStorageMask, void>)Glfw.Glfw.GetProcAddress(
                nameof(glNamedBufferStorage));
        _glNamedBufferStorageDelegate(buffer, size, dataPtr, bufferStorageMask);
    }

    [UnmanagedCallersOnly]
    private static void glNamedBufferData(
        uint buffer,
        uint size,
        void* dataPtr,
        BufferUsage bufferUsage)
    {
        _glNamedBufferDataDelegate =
            (delegate* unmanaged<uint, uint, void*, BufferUsage, void>)Glfw.Glfw.GetProcAddress(
                nameof(glNamedBufferData));
        _glNamedBufferDataDelegate(buffer, size, dataPtr, bufferUsage);
    }

    [UnmanagedCallersOnly]
    private static void glNamedBufferSubData(
        uint buffer,
        int offset,
        long size,
        void* dataPtr)
    {
        _glNamedBufferSubDataDelegate =
            (delegate* unmanaged<uint, int, long, void*, void>)Glfw.Glfw.GetProcAddress(nameof(glNamedBufferSubData));
        _glNamedBufferSubDataDelegate(buffer, offset, size, dataPtr);
    }

    [UnmanagedCallersOnly]
    private static void glObjectLabel(ObjectIdentifier objectIdentifier, uint id, int length, byte* label)
    {
        _glObjectLabelDelegate =
            (delegate* unmanaged<ObjectIdentifier, uint, int, byte*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glObjectLabel));
        _glObjectLabelDelegate(objectIdentifier, id, length, label);
    }

    [UnmanagedCallersOnly]
    private static void glPointSize(float pointSize)
    {
        _glPointSizeDelegate = (delegate* unmanaged<float, void>)Glfw.Glfw.GetProcAddress(nameof(glPointSize));
        _glPointSizeDelegate(pointSize);
    }

    [UnmanagedCallersOnly]
    private static void glPolygonMode(
        PolygonModeType polygonMode,
        FillMode fillMode)
    {
        _glPolygonModeDelegate =
            (delegate* unmanaged<PolygonModeType, FillMode, void>)Glfw.Glfw.GetProcAddress(nameof(glPolygonMode));
        _glPolygonModeDelegate(polygonMode, fillMode);
    }

    [UnmanagedCallersOnly]
    private static void glPolygonOffset(
        float factor,
        float units)
    {
        _glPolygonOffsetDelegate =
            (delegate* unmanaged<float, float, void>)Glfw.Glfw.GetProcAddress(nameof(glPolygonOffset));
        _glPolygonOffsetDelegate(factor, units);
    }

    [UnmanagedCallersOnly]
    private static void glProgramParameteri(
        uint programId,
        ProgramParameterType programParameterType,
        int value)
    {
        _glProgramParameteriDelegate =
            (delegate* unmanaged<uint, ProgramParameterType, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glProgramParameteri));
        _glProgramParameteriDelegate(programId, programParameterType, value);
    }

    [UnmanagedCallersOnly]
    private static void glStencilMask(byte stencil)
    {
        _glStencilMaskDelegate = (delegate* unmanaged<byte, void>)Glfw.Glfw.GetProcAddress(nameof(glStencilMask));
        _glStencilMaskDelegate(stencil);
    }

    [UnmanagedCallersOnly]
    private static void glTextureView(
        uint textureViewId,
        TextureTarget target,
        uint textureId,
        SizedInternalFormat internalformat,
        uint minLevel,
        uint numLevels,
        uint minLayer,
        uint numLayers)
    {
        _glTextureViewDelegate =
            (delegate* unmanaged<uint, TextureTarget, uint, SizedInternalFormat, uint, uint, uint, uint, void>)Glfw.Glfw
                .GetProcAddress(nameof(glTextureView));
        _glTextureViewDelegate(
            textureViewId,
            target,
            textureId,
            internalformat,
            minLevel,
            numLevels,
            minLayer,
            numLayers);
    }

    [UnmanagedCallersOnly]
    private static void glUseProgram(uint programId)
    {
        _glUseProgramDelegate = (delegate* unmanaged<uint, void>)Glfw.Glfw.GetProcAddress(nameof(glUseProgram));
        _glUseProgramDelegate(programId);
    }

    [UnmanagedCallersOnly]
    private static void glUseProgramStages(
        uint programPipelineId,
        UseProgramStageMask useProgramStageMask,
        uint programId)
    {
        _glUseProgramStagesDelegate =
            (delegate* unmanaged<uint, UseProgramStageMask, uint, void>)Glfw.Glfw.GetProcAddress(
                nameof(glUseProgramStages));
        _glUseProgramStagesDelegate(programPipelineId, useProgramStageMask, programId);
    }

    [UnmanagedCallersOnly]
    private static void glVertexArrayAttribBinding(
        uint vertexArray,
        uint attributeIndex,
        uint bindingIndex)
    {
        _glVertexArrayAttribBindingDelegate =
            (delegate* unmanaged<uint, uint, uint, void>)Glfw.Glfw.GetProcAddress(
                nameof(glVertexArrayAttribBinding));
        _glVertexArrayAttribBindingDelegate(vertexArray, attributeIndex, bindingIndex);
    }

    [UnmanagedCallersOnly]
    private static void glVertexArrayAttribFormat(
        uint vertexArray,
        uint attributeIndex,
        int dataTypeSize,
        DataType dataType,
        byte isNormalized,
        uint relativeOffset)
    {
        _glVertexArrayAttribFormatDelegate =
            (delegate* unmanaged<uint, uint, int, DataType, byte, uint, void>)Glfw.Glfw.GetProcAddress(
                nameof(glVertexArrayAttribFormat));
        _glVertexArrayAttribFormatDelegate(
            vertexArray,
            attributeIndex,
            dataTypeSize,
            dataType,
            isNormalized,
            relativeOffset);
    }

    [UnmanagedCallersOnly]
    private static void glVertexArrayAttribIFormat(
        uint vertexArray,
        uint attributeIndex,
        int dataTypeSize,
        DataType dataType,
        uint relativeOffset)
    {
        _glVertexArrayAttribIFormatDelegate =
            (delegate* unmanaged<uint, uint, int, DataType, uint, void>)Glfw.Glfw.GetProcAddress(
                nameof(glVertexArrayAttribIFormat));
        _glVertexArrayAttribIFormatDelegate(
            vertexArray,
            attributeIndex,
            dataTypeSize,
            dataType,
            relativeOffset);
    }

    [UnmanagedCallersOnly]
    private static void glViewport(
        int left,
        int top,
        int width,
        int height)
    {
        _glViewportDelegate =
            (delegate* unmanaged<int, int, int, int, void>)Glfw.Glfw.GetProcAddress(nameof(glViewport));
        _glViewportDelegate(left, top, width, height);
    }

    [UnmanagedCallersOnly]
    private static void glScissor(
        int left,
        int top,
        int width,
        int height)
    {
        _glScissorDelegate =
            (delegate* unmanaged<int, int, int, int, void>)Glfw.Glfw.GetProcAddress(nameof(glScissor));
        _glScissorDelegate(left, top, width, height);
    }

    [UnmanagedCallersOnly]
    private static void glTextureSubImage1D(
        uint texture,
        int level,
        int xOffset,
        int width,
        PixelFormat format,
        DataType type,
        void* pixels)
    {
        _glTextureSubImage1DDelegate =
            (delegate* unmanaged<uint, int, int, int, PixelFormat, DataType, void*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glTextureSubImage1D));
        _glTextureSubImage1DDelegate(
            texture,
            level,
            xOffset,
            width,
            format,
            type,
            pixels);
    }

    [UnmanagedCallersOnly]
    private static void glTextureSubImage2D(
        uint texture,
        int level,
        int xOffset,
        int yOffset,
        int width,
        int height,
        PixelFormat format,
        DataType type,
        void* pixels)
    {
        _glTextureSubImage2DDelegate =
            (delegate* unmanaged<uint, int, int, int, int, int, PixelFormat, DataType, void*, void>)Glfw.Glfw
                .GetProcAddress(
                    nameof(glTextureSubImage2D));
        _glTextureSubImage2DDelegate(
            texture,
            level,
            xOffset,
            yOffset,
            width,
            height,
            format,
            type,
            pixels);
    }

    [UnmanagedCallersOnly]
    private static void glTextureSubImage3D(
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
        void* pixels)
    {
        _glTextureSubImage3DDelegate =
            (delegate* unmanaged<uint, int, int, int, int, int, int, int, PixelFormat, DataType, void*, void>)Glfw.Glfw
                .GetProcAddress(
                    nameof(glTextureSubImage3D));
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
            pixels);
    }

    [UnmanagedCallersOnly]
    private static void glNamedFramebufferTexture(
        uint framebuffer,
        FramebufferAttachment attachment,
        uint texture,
        int level)
    {
        _glNamedFramebufferTextureDelegate =
            (delegate* unmanaged<uint, FramebufferAttachment, uint, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glNamedFramebufferTexture));
        _glNamedFramebufferTextureDelegate(framebuffer, attachment, texture, level);
    }

    [UnmanagedCallersOnly]
    private static void glNamedFramebufferDrawBuffers(
        uint framebuffer,
        uint count,
        DrawBuffer* buffers)
    {
        _glNamedFramebufferDrawBuffersDelegate =
            (delegate* unmanaged<uint, uint, DrawBuffer*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glNamedFramebufferDrawBuffers));
        _glNamedFramebufferDrawBuffersDelegate(framebuffer, count, buffers);
    }

    [UnmanagedCallersOnly]
    private static void glDebugMessageCallback(
        IntPtr callback,
        void* userParam)
    {
        _glDebugMessageCallbackDelegate =
            (delegate* unmanaged<IntPtr, void*, void>)Glfw.Glfw.GetProcAddress(nameof(glDebugMessageCallback));
        _glDebugMessageCallbackDelegate(callback, userParam);
    }

    [UnmanagedCallersOnly]
    private static void glVertexArrayVertexBuffer(
        uint vao,
        uint bindingIndex,
        uint buffer,
        IntPtr offset,
        int stride)
    {
        _glVertexArrayVertexBufferDelegate =
            (delegate* unmanaged<uint, uint, uint, IntPtr, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glVertexArrayVertexBuffer));
        _glVertexArrayVertexBufferDelegate(vao, bindingIndex, buffer, offset, stride);
    }

    [UnmanagedCallersOnly]
    private static void glVertexArrayElementBuffer(
        uint vao,
        uint buffer)
    {
        _glVertexArrayElementBufferDelegate =
            (delegate* unmanaged<uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glVertexArrayElementBuffer));
        _glVertexArrayElementBufferDelegate(vao, buffer);
    }

    [UnmanagedCallersOnly]
    private static void glPushDebugGroup(
        DebugSource source,
        uint id,
        int length,
        byte* message)
    {
        _glPushDebugGroupDelegate =
            (delegate* unmanaged<DebugSource, uint, int, byte*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glPushDebugGroup));
        _glPushDebugGroupDelegate(source, id, length, message);
    }

    [UnmanagedCallersOnly]
    private static void glPopDebugGroup()
    {
        _glPopDebugGroupDelegate = (delegate* unmanaged<void>)Glfw.Glfw.GetProcAddress(nameof(glPopDebugGroup));
        _glPopDebugGroupDelegate();
    }

    [UnmanagedCallersOnly]
    private static void glMultiDrawElementsIndirect(
        PrimitiveType primitiveType,
        IndexElementType indexElementType,
        void* indirectDataPtr,
        int indirectDrawCount,
        int indirectDataStride)
    {
        _glMultiDrawElementsIndirectDelegate =
            (delegate* unmanaged<PrimitiveType, IndexElementType, void*, int, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glMultiDrawElementsIndirect));
        _glMultiDrawElementsIndirectDelegate(
            primitiveType,
            indexElementType,
            indirectDataPtr,
            indirectDrawCount,
            indirectDataStride);
    }

    [UnmanagedCallersOnly]
    private static ulong glGetTextureHandleARB(uint textureId)
    {
        _glGetTextureHandleARBDelegate =
            (delegate* unmanaged<uint, ulong>)Glfw.Glfw.GetProcAddress(nameof(glGetTextureHandleARB));
        return _glGetTextureHandleARBDelegate(textureId);
    }

    [UnmanagedCallersOnly]
    private static ulong glGetTextureSamplerHandleARB(
        uint textureId,
        uint samplerId)
    {
        _glGetTextureSamplerHandleARBDelegate =
            (delegate* unmanaged<uint, uint, ulong>)Glfw.Glfw.GetProcAddress(nameof(glGetTextureSamplerHandleARB));
        return _glGetTextureSamplerHandleARBDelegate(textureId, samplerId);
    }

    [UnmanagedCallersOnly]
    private static void glMakeTextureHandleResidentARB(ulong handle)
    {
        _glMakeTextureHandleResidentARBDelegate =
            (delegate* unmanaged<ulong, void>)Glfw.Glfw.GetProcAddress(nameof(glMakeTextureHandleResidentARB));
        _glMakeTextureHandleResidentARBDelegate(handle);
    }

    [UnmanagedCallersOnly]
    private static void glMakeTextureHandleNonResidentARB(ulong handle)
    {
        _glMakeTextureHandleNonResidentARBDelegate =
            (delegate* unmanaged<ulong, void>)Glfw.Glfw.GetProcAddress(nameof(glMakeTextureHandleNonResidentARB));
        _glMakeTextureHandleNonResidentARBDelegate(handle);
    }

    [UnmanagedCallersOnly]
    private static void glBindTextureUnit(uint unit, uint texture)
    {
        _glBindTextureUnitDelegate =
            (delegate* unmanaged<uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindTextureUnit));
        _glBindTextureUnitDelegate(unit, texture);
    }

    [UnmanagedCallersOnly]
    private static void glTextureStorage1D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width)
    {
        _glTextureStorage1DDelegate =
            (delegate* unmanaged<uint, uint, SizedInternalFormat, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glTextureStorage1D));
        _glTextureStorage1DDelegate(
            texture,
            levels,
            internalFormat,
            width);
    }

    [UnmanagedCallersOnly]
    private static void glTextureStorage2D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width,
        int height)
    {
        _glTextureStorage2DDelegate =
            (delegate* unmanaged<uint, uint, SizedInternalFormat, int, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glTextureStorage2D));
        _glTextureStorage2DDelegate(
            texture,
            levels,
            internalFormat,
            width,
            height);
    }

    [UnmanagedCallersOnly]
    private static void glTextureStorage3D(
        uint texture,
        uint levels,
        SizedInternalFormat internalFormat,
        int width,
        int height,
        int depth)
    {
        _glTextureStorage3DDelegate =
            (delegate* unmanaged<uint, uint, SizedInternalFormat, int, int, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glTextureStorage3D));
        _glTextureStorage3DDelegate(
            texture,
            levels,
            internalFormat,
            width,
            height,
            depth);
    }

    [UnmanagedCallersOnly]
    private static void glCreateSamplers(
        int count,
        int* samplers)
    {
        _glCreateSamplersDelegate =
            (delegate* unmanaged<int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateSamplers));
        _glCreateSamplersDelegate(count, samplers);
    }

    [UnmanagedCallersOnly]
    private static void glSamplerParameteri(
        uint sampler,
        SamplerParameterI parameterName,
        int param)
    {
        _glSamplerParameteriDelegate =
            (delegate* unmanaged<uint, SamplerParameterI, int, void>)Glfw.Glfw.GetProcAddress(
                nameof(glSamplerParameteri));
        _glSamplerParameteriDelegate(sampler, parameterName, param);
    }

    [UnmanagedCallersOnly]
    private static void glSamplerParameteriv(
        uint sampler,
        SamplerParameterI parameterName,
        int* parameterValues)
    {
        _glSamplerParameterivDelegate =
            (delegate* unmanaged<uint, SamplerParameterI, int*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glSamplerParameteriv));
        _glSamplerParameterivDelegate(sampler, parameterName, parameterValues);
    }

    [UnmanagedCallersOnly]
    private static void glSamplerParameterf(
        uint sampler,
        SamplerParameterF parameterName,
        float parameterValue)
    {
        _glSamplerParameterfDelegate =
            (delegate* unmanaged<uint, SamplerParameterF, float, void>)Glfw.Glfw.GetProcAddress(
                nameof(glSamplerParameterf));
        _glSamplerParameterfDelegate(sampler, parameterName, parameterValue);
    }

    [UnmanagedCallersOnly]
    private static void glSamplerParameterfv(
        uint sampler,
        SamplerParameterF parameterName,
        float* parameterValues)
    {
        _glSamplerParameterfvDelegate =
            (delegate* unmanaged<uint, SamplerParameterF, float*, void>)Glfw.Glfw.GetProcAddress(
                nameof(glSamplerParameterfv));
        _glSamplerParameterfvDelegate(sampler, parameterName, parameterValues);
    }

    [UnmanagedCallersOnly]
    private static void glBindSampler(uint unit, uint sampler)
    {
        _glBindSamplerDelegate = (delegate* unmanaged<uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glBindSampler));
        _glBindSamplerDelegate(unit, sampler);
    }

    [UnmanagedCallersOnly]
    private static void glFinish()
    {
        _glFinishDelegate = (delegate* unmanaged<void>)Glfw.Glfw.GetProcAddress(nameof(glFinish));
        _glFinishDelegate();
    }

    [UnmanagedCallersOnly]
    private static void glBlitNamedFramebuffer(
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
        _glBlitNamedFramebufferDelegate =
            (delegate* unmanaged<uint, uint, int, int, int, int, int, int, int, int, ClearBufferMask,
                BlitFramebufferFilter, void>)Glfw.Glfw.GetProcAddress(nameof(glBlitNamedFramebuffer));
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

    [UnmanagedCallersOnly]
    private static byte* glGetString(StringName name)
    {
        _glGetStringDelegate = (delegate* unmanaged<StringName, byte*>)Glfw.Glfw.GetProcAddress(nameof(glGetString));
        return _glGetStringDelegate(name);
    }

    [UnmanagedCallersOnly]
    private static void glBeginQuery(QueryTarget target, int id)
    {
        _glBeginQueryDelegate = (delegate* unmanaged<QueryTarget, int, void>)Glfw.Glfw.GetProcAddress(nameof(glBeginQuery));
        _glBeginQueryDelegate(target, id);
    }

    [UnmanagedCallersOnly]
    private static void glEndQuery(QueryTarget target)
    {
        _glEndQueryDelegate = (delegate* unmanaged<QueryTarget, void>)Glfw.Glfw.GetProcAddress(nameof(glEndQuery));
        _glEndQueryDelegate(target);
    }

    [UnmanagedCallersOnly]
    private static void glCreateQueries(QueryTarget target, int n, int* ids)
    {
        _glCreateQueriesDelegate = (delegate* unmanaged<QueryTarget, int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glCreateQueries));
        _glCreateQueriesDelegate(target, n, ids);
    }

    [UnmanagedCallersOnly]
    private static void glGetQueryObjectuiv(int id, QueryObjectParameterName pname, uint* parameters)
    {
        _glGetQueryObjectuivDelegate = (delegate* unmanaged<int, QueryObjectParameterName, uint*, void>)Glfw.Glfw.GetProcAddress(nameof(glGetQueryObjectuiv));
        _glGetQueryObjectuivDelegate(id, pname, parameters);
    }

    [UnmanagedCallersOnly]
    private static void glMemoryBarrier(MemoryBarrierMask barriers)
    {
        _glMemoryBarrierDelegate = (delegate* unmanaged<MemoryBarrierMask, void>)Glfw.Glfw.GetProcAddress(nameof(glMemoryBarrier));
        _glMemoryBarrierDelegate(barriers);
    }

    [UnmanagedCallersOnly]
    private static void glBindImageTexture(
        uint unit,
        int texture,
        int level,
        byte layered,
        int layer,
        MemoryAccess access,
        SizedInternalFormat format)
    {
        _glBindImageTextureDelegate = (delegate* unmanaged<uint, int, int, byte, int, MemoryAccess, SizedInternalFormat, void>)Glfw.Glfw.GetProcAddress(nameof(glBindImageTexture));
        _glBindImageTextureDelegate(unit, texture, level, layered, layer, access, format);
    }

    [UnmanagedCallersOnly]
    private static void glBindImageTextures(
        uint first,
        int count,
        int* textures)
    {
        _glBindImageTexturesDelegate = (delegate* unmanaged<uint, int, int*, void>)Glfw.Glfw.GetProcAddress(nameof(glBindImageTextures));
        _glBindImageTexturesDelegate(first, count, textures);
    }

    [UnmanagedCallersOnly]
    private static void glDispatchCompute(uint numGroupsX, uint numGroupsY, uint numGroupsZ)
    {
        _glDispatchComputeDelegate = (delegate* unmanaged<uint, uint, uint, void>)Glfw.Glfw.GetProcAddress(nameof(glDispatchCompute));
        _glDispatchComputeDelegate(numGroupsX, numGroupsY, numGroupsZ);
    }

    [UnmanagedCallersOnly]
    private static void glDispatchComputeIndirect(IntPtr indirect)
    {
        _glDispatchComputeIndirectDelegate = (delegate* unmanaged<IntPtr, void>)Glfw.Glfw.GetProcAddress(nameof(glDispatchComputeIndirect));
        _glDispatchComputeIndirectDelegate(indirect);
    }
}