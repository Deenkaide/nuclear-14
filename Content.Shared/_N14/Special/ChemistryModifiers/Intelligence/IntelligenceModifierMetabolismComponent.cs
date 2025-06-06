/*
using Robust.Shared.Serialization;
using Robust.Shared.GameStates;

namespace Content.Shared._N14.Special.ChemistryModifiers;

[RegisterComponent]
[NetworkedComponent]
public sealed partial class IntelligenceModifierMetabolismComponent : Component
{
    [ViewVariables]
    public int IntelligenceModifier { get; set; }

    /// <summary>
    /// When the current modifier is expected to end.
    /// </summary>
    [ViewVariables]
    public TimeSpan ModifierTimer { get; set; } = TimeSpan.Zero;

    [Serializable, NetSerializable]
    public sealed class IntelligenceModifierMetabolismComponentState : ComponentState
    {
        public int IntelligenceModifier { get; }
        public TimeSpan ModifierTimer { get; }

        public IntelligenceModifierMetabolismComponentState(int intelligenceModifier, TimeSpan modifierTimer)
        {
            IntelligenceModifier = intelligenceModifier;
            ModifierTimer = modifierTimer;
        }
    }
}


*/
