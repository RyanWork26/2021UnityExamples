using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class SceneColorEffect : ScriptableRendererFeature
{
    public Material effectMat;
    public RenderPassEvent renderpassEvent;
    class CustomRenderPass : ScriptableRenderPass
    {
        public Material mat;

        public RenderTargetIdentifier colorIdentifier;
        // This method is called before executing the render pass.
        // It can be used to configure render targets and their clear state. Also to create temporary render target textures.
        // When empty this render pass will render to the active camera render target.
        // You should never call CommandBuffer.SetRenderTarget. Instead call <c>ConfigureTarget</c> and <c>ConfigureClear</c>.
        // The render pipeline will ensure target setup and clearing happens in an performance manner.
        public override void Configure(CommandBuffer cmd, RenderTextureDescriptor cameraTextureDescriptor)
        {
        }

        public void SetIdentifier(RenderTargetIdentifier rti)
        {
            colorIdentifier = rti;

        }

        public void SetMaterial(Material Mat)
        {
            mat = Mat;
        }

        // Here you can implement the rendering logic.
        // Use <c>ScriptableRenderContext</c> to issue drawing commands or execute command buffers
        // https://docs.unity3d.com/ScriptReference/Rendering.ScriptableRenderContext.html
        // You don't have to call ScriptableRenderContext.submit, the render pipeline will call it at specific points in the pipeline.
        public override void Execute(ScriptableRenderContext context, ref RenderingData renderingData)
        {
            CommandBuffer cmd = new CommandBuffer();

            cmd.GetTemporaryRT(Shader.PropertyToID("EffectTempRT"), renderingData.cameraData.cameraTargetDescriptor);
            RenderTargetIdentifier temp = new RenderTargetIdentifier("EffectTempRT");

            cmd.Blit(colorIdentifier, temp, mat, 0);
            cmd.Blit(temp,colorIdentifier);

            context.ExecuteCommandBuffer(cmd);
            cmd.ReleaseTemporaryRT(Shader.PropertyToID("EffectTempRT"));
            cmd.Clear();


        }

        /// Cleanup any allocated resources that were created during the execution of this render pass.
        public override void FrameCleanup(CommandBuffer cmd)
        {
        }
    }

    CustomRenderPass m_ScriptablePass;

    public override void Create()
    {
        m_ScriptablePass = new CustomRenderPass();

        m_ScriptablePass.SetMaterial(effectMat);
        // Configures where the render pass should be injected.
        m_ScriptablePass.renderPassEvent = renderpassEvent;
    }

    // Here you can inject one or multiple render passes in the renderer.
    // This method is called when setting up the renderer once per-camera.
    public override void AddRenderPasses(ScriptableRenderer renderer, ref RenderingData renderingData)
    {
        m_ScriptablePass.SetIdentifier(renderer.cameraColorTarget);
        renderer.EnqueuePass(m_ScriptablePass);
    }
}


