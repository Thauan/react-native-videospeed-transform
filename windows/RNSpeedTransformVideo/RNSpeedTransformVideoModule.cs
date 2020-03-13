using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Speed.Transform.Video.RNSpeedTransformVideo
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSpeedTransformVideoModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSpeedTransformVideoModule"/>.
        /// </summary>
        internal RNSpeedTransformVideoModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSpeedTransformVideo";
            }
        }
    }
}
