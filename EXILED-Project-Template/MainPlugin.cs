namespace EXILED_Project_Template
{
    using System;

    using Exiled.API.Features;
    using Exiled.API.Interfaces;
    using Exiled.API.Enums;

    public class MainPlugin : Plugin<Config, Translations>
    {
        /*
         * Put extra plugin info fields here :slight_smile:
        */

        /// <summary>
        /// Gets or sets the <see cref="MainPlugin"/> singleton.
        /// </summary>
        public static MainPlugin Singleton { get; set; }

        /// <summary>
        /// Gets the <see cref="Config"/> singleton.
        /// </summary>
        public static Config Configs => Singleton?.Config;

        /// <summary>
        /// Gets the <see cref="Translations"/> singleton.
        /// </summary>
        public static Translations Translations => Singleton?.Translation;

        /// <inheritdoc/>
        public override string Name => "EXILED_Project_Template_v1";

        /// <inheritdoc/>
        public override string Author => "Placeholder";

        /// <inheritdoc/>
        public override PluginPriority Priority => PluginPriority.Low;

        /// <inheritdoc/>
        public override Version Version => new(0, 0, 0);

        /// <inheritdoc/>
        public override Version RequiredExiledVersion => new(8, 14, 1);
    }
}
