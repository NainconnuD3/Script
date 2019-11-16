// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^
// *.txt files are not loaded automatically by TurboHUD
// you have to change this file's extension to .cs to enable it
// ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^

using Turbo.Plugins.Default;

namespace Turbo.Plugins.User
{

    public class PluginEnablerOrDisablerPlugin : BasePlugin, ICustomizer
    {

        public PluginEnablerOrDisablerPlugin()
        {
            Enabled = true;
        }

        public override void Load(IController hud)
        {
            base.Load(hud);
        }

        // "Customize" methods are automatically executed after every plugin is loaded.
        // So these methods can use Hud.GetPlugin<class> to access the plugin instances' public properties (like decorators, Enabled flag, parameters, etc)
        // Make sure you test the return value against null!
        public void Customize()
        {
            // basic examples

            // turn on MultiplayerExperienceRangePlugin
            Hud.TogglePlugin<MultiplayerExperienceRangePlugin>(true);

            // turn off sell darkening
            Hud.GetPlugin<InventoryAndStashPlugin>().NotGoodDisplayEnabled = true;

            // disable arcane affix label
            Hud.GetPlugin<EliteMonsterAffixPlugin>().AffixDecorators.Remove(MonsterAffix.Arcane);

            // override an elite affix's text
            Hud.GetPlugin<EliteMonsterAffixPlugin>().CustomAffixNames.Add(MonsterAffix.Desecrator, "DES");
			
			
			// AriadnesThreadPlugin Customization
            Hud.RunOnPlugin<Resu.AriadnesThreadPlugin>(plugin => 
            { 
               
			plugin.ThreadBetweenPlayers = true; // Set to false to disable the thread between players.
			plugin.Pools = true; // Set to true to enable pools of reflection.
            plugin.BannerTimeSeconds = 30; // Number of seconds you want each player's banner to stay.
            plugin.MetricSystem = false; // Set to true to use metric system for bounty distance.
            });  
			
			
			// disable parangon screeshot
			Hud.GetPlugin<ParagonCapturePlugin>().Enabled = false;

        }

    }

}