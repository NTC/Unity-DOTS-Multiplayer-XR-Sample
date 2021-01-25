using Unity.Entities;

[GenerateAuthoringComponent]
public struct CameraAuthoringComponent : IComponentData
{
    public Entity Prefab;
}