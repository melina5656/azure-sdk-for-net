// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> Describes Advanced Audio Codec (AAC) audio encoding settings. </summary>
    public partial class AacAudio : MediaAudioBase
    {
        /// <summary> Initializes a new instance of <see cref="AacAudio"/>. </summary>
        public AacAudio()
        {
            OdataType = "#Microsoft.Media.AacAudio";
        }

        /// <summary> Initializes a new instance of <see cref="AacAudio"/>. </summary>
        /// <param name="odataType"> The discriminator for derived types. </param>
        /// <param name="label"> An optional label for the codec. The label can be used to control muxing behavior. </param>
        /// <param name="channels"> The number of channels in the audio. </param>
        /// <param name="samplingRate"> The sampling rate to use for encoding in hertz. </param>
        /// <param name="bitrate"> The bitrate, in bits per second, of the output encoded audio. </param>
        /// <param name="profile"> The encoding profile to be used when encoding audio with AAC. </param>
        internal AacAudio(string odataType, string label, int? channels, int? samplingRate, int? bitrate, AacAudioProfile? profile) : base(odataType, label, channels, samplingRate, bitrate)
        {
            Profile = profile;
            OdataType = odataType ?? "#Microsoft.Media.AacAudio";
        }

        /// <summary> The encoding profile to be used when encoding audio with AAC. </summary>
        public AacAudioProfile? Profile { get; set; }
    }
}
