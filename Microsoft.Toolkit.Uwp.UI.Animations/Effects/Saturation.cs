// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// using Microsoft.Graphics.Canvas.Effects;
using Microsoft.UI.Composition;

namespace Microsoft.Toolkit.Uwp.UI.Animations.Effects
{
    /// <summary>
    /// An animation effect that applies saturation.
    /// </summary>
    /// <seealso cref="Microsoft.Toolkit.Uwp.UI.Animations.Effects.AnimationEffect" />
    public class Saturation : AnimationEffect
    {
        /// <summary>
        /// Gets the name of the effect.
        /// </summary>
        /// <value>
        /// The name of the effect.
        /// </value>
        public override string EffectName { get; } = "Saturation";

        /// <summary>
        /// Applies the effect.
        /// </summary>
        /// <returns>
        /// An array of strings of the effect properties to change.
        /// </returns>
        public override string[] ApplyEffect()
        {
            /*
            var saturationEffect = new SaturationEffect
            {
                Saturation = 1f,
                Name = EffectName,
                Source = new CompositionEffectSourceParameter("source")
            };
            */

            var propertyToChange = $"{EffectName}.Saturation";
            var propertiesToAnimate = new[] { propertyToChange };

            /*
            EffectBrush = Compositor.CreateEffectFactory(saturationEffect, propertiesToAnimate).CreateBrush();
            EffectBrush.SetSourceParameter("source", Compositor.CreateBackdropBrush());
            */

            return propertiesToAnimate;
        }
    }
}