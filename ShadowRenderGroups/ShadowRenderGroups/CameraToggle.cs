using Xenko.Core.Mathematics;
using Xenko.Input;
using Xenko.Engine;
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable UnassignedField.Global

namespace ShadowRenderGroups
{
    public class CameraToggle : SyncScript
    {
        public CameraComponent Camera1;
        public CameraComponent Camera2;

        private string selectedCamera = "[Camera1]";

        public override void Start()
        {
            // Initialization of the script.
        }

        public override void Update()
        {
            DebugText.Print($"Tab to switch: {selectedCamera}",new Int2(x: 5, y: 10));
            DebugText.Print("Figure out how to get rid of the sphere shadow (not the cube or cube shadow) on Camera1 to unlock unlimited happiness.",new Int2(x: 5, y: 710));

            if (Input.IsKeyPressed(Keys.Tab)) {
                switch (Camera1.Enabled) {
                    case true:
                        Camera1.Enabled = false;
                        Camera2.Enabled = true;
                        selectedCamera = $"[{Camera2.Entity.Name}]";
                        break;
                    default:
                        Camera1.Enabled = true;
                        Camera2.Enabled = false;
                        selectedCamera = $"[{Camera1.Entity.Name}]";
                        break;
                }
            }
        }
    }
}
