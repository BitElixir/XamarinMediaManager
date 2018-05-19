using System.Threading.Tasks;

namespace Plugin.MediaManager.Abstractions
{
    public interface IAudioPlayer : IPlaybackManager
    {
        Task SetRate(float rate = 1.0f);
    }
}
