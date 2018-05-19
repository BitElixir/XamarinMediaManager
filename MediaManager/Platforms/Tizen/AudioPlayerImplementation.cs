using System.Threading.Tasks;
using Plugin.MediaManager.Abstractions;

namespace Plugin.MediaManager
{
    public class AudioPlayerImplementation : MediaPlayerBase, IAudioPlayer
    {
        public AudioPlayerImplementation(IVolumeManager volumeManager, IMediaExtractor mediaExtractor) : base(volumeManager, mediaExtractor)
        {
        }

        public Task SetRate(float rate = 1)
        {
            throw new System.NotImplementedException();
        }
    }
}
