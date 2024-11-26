# Sample for TriSlice Component Plugin

This sample project showcases the **TriSlice Component**.

The **TriSlice Component** plugin introduces a 3D slicing technique known as 
**27 Slicing** to Unreal Engine. This method enables dynamic, non-uniform 
scaling of 3D meshes while preserving artistic fidelity, analogous to 
**9-slicing** in 2D textures. By dividing a 3D mesh into 27 regions, this 
component provides efficient scaling and deformation with minimal distortion, 
preserving the geometry of key areas like corners, edges, and the center.

## Features

- **27 Slicing for 3D Meshes**: Scale and deform meshes dynamically while 
  preserving critical details.
- **Precise Slice Borders**: Define regions of the mesh (corners, edges, faces, 
  center) with normalized slice borders for each axis.
- **Customizable Scaling Behavior**: Control whether the center region 
  stretches or remains fixed during scaling.
- **Pivot-Based Slicing**: Adjust the slicing pivot for precise control of 
  slice borders.
- **Collision Mesh Generation**: Automatically generate a collision mesh for 
  the sliced geometry.
- **Asynchronous Slicing**: Perform slicing computations asynchronously for 
  better performance.
- **Mesh Scale Control**: Use either the actor scale or a custom `MeshScale` 
  property for slicing.

## Installation

1. Clone or download this repository into your Unreal project’s `Plugins` 
   folder.
2. Enable the plugin in the **Plugins** menu in Unreal Editor.
3. Restart the editor to complete the installation.

## Getting Started

### Adding the Component

1. Open your actor’s blueprint or C++ class.
2. Add the **TriSlice Component** as a child of your actor.
3. Assign a **Static Mesh** to the component's `Mesh` property.  
   > **Note**: Ensure that **CPU Access** is enabled for the assigned mesh:
   - Open the mesh asset in the editor.
   - Under **Details** → **General Settings** → **Advanced**, enable 
     **Allow CPU Access**.

### Configuring Slicing

The primary slicing behavior is defined by the following properties:

- **Slice Borders**:
  - `BorderXNegative`, `BorderXPositive`
  - `BorderYNegative`, `BorderYPositive`
  - `BorderZNegative`, `BorderZPositive`  
  These normalized values (0.0–1.0) define where the mesh is divided along 
  each axis. If the border is set to 1.0, the mesh will stretch on that side
  as it normally does when scaling. If the border is set to 0.8, only the 
  inner 80% will stretch, while the outer 20% remains fixed.

- **Pivot Adjustment**:
  - Use the `SlicerPivotOffset` property to fine-tune the slicing pivot if it 
    differs from the mesh’s center.

- **Center Scaling**:
  - Use the `ScaleCenterMode` property to determine whether the center region 
    stretches during scaling. This is particularly useful for preserving key 
    features like engravings or functional elements. See the sample for a
    visual example.

### Triggering Slicing

- **Automatic Slicing**: Slicing occurs automatically when:
  - The game starts.
  - The owning actor’s scale changes.
- **Manual Slicing**: Call the `SliceMesh` method to trigger slicing manually.

### Debugging Slicing

Enable debug properties to visualize slicing behavior in the editor:
- `bDebugDrawPivot`: Display the slicing pivot.
- `bDebugDrawBorderX`, `bDebugDrawBorderY`, `bDebugDrawBorderZ`: Display slice 
  borders for each axis.

### Collision and Performance

- **Collision Mesh**: Enable or disable collision mesh generation using the 
  `bGenerateCollision` property.
- **Asynchronous Slicing**: Improve performance by enabling `bAsyncSlice` 
  (enabled by default).

### Using Custom Mesh Scale

If you do not want to scale the actor itself:
1. Set `bUseActorScale` to `false`.
2. Use the `MeshScale` property to define the mesh scale directly.

### Documentation

For detailed information on the available properties and methods of the 
**TriSlice Component**, refer to the API documentation provided in the 
source code.

## Known Issues

- Textures may stretch in the center region if not designed for scaling. Adding 
  additional loop cuts may mitigate this issue.
- Ensure CPU access is enabled for the mesh, or slicing will not function.
