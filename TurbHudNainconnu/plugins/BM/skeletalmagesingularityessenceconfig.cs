using Turbo.Plugins.Default;

namespace Turbo.Plugins.BM
{
    public class SkeletalMageSingularityEssenceConfig : BasePlugin, ICustomizer
    {

        public SkeletalMageSingularityEssenceConfig()
        {
            Enabled = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
        }

        public void Customize()
        {
            Hud.RunOnPlugin<BM.SkeletalMageSingularityEssencePlugin>(plugin =>
            {
                
				//To disable the plugin in town: change to false
				plugin.ShowInTown = true;
				
				//Value of your Reaper's Wraps: Health globes restore 25-30% of your primary resource
				plugin.ReapersWrapsResourceRestore = 30;
				
				//Default position is under the feet of the player
				//plugin.XPos = 
				//plugin.YPos =
				
            });
        }

    }

}