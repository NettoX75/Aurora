﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aurora.EffectsEngine;

namespace Aurora.Settings.Layers
{
    public class DefaultLayerHandler : LayerHandler
    {
        public DefaultLayerHandler()
        {
            _Control = new Control_DefaultLayer();
            _Type = LayerType.Default;
        }

        public override EffectLayer Render()
        {
            return base.Render();
        }
    }
}
