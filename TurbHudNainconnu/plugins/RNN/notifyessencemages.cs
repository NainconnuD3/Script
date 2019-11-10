using System;
using Turbo.Plugins.Default;
using System.Linq;
using System.Threading;

namespace Turbo.Plugins.RNN
{
	public class NotifyEssenceMages : BasePlugin, IAfterCollectHandler, INewAreaHandler
	{
        
		public int ResourceHigh { get; set; }
		public int ResourceLow { get; set; }

		public bool  ResourceMaxPlay { get; set; } = false;
		public bool  ResourceMinPlay { get; set; } = false;

		public bool HighNotify { get; set; }
		public bool LowNotify { get; set; }
		public string HighNotifyWav { get; set; }
		public string LowNotifyWav { get; set; }
			
		public NotifyEssenceMages()
		{
			Enabled = true;		
        }
        
        public override void Load(IController hud)
        {
			base.Load(hud);
			
			ResourceHigh = 90;
			ResourceLow = 15;
			HighNotify = true;
			LowNotify = false;
			HighNotifyWav = "Resource-High.wav";
			LowNotifyWav = "Resource-Low.wav";	
        }
		
        public void Play_Sound(string Sonido)
        {
			var playSonido = Hud.Sound.LoadSoundPlayer(Sonido);            
			ThreadPool.QueueUserWorkItem(state =>
			{
				try  { playSonido.PlaySync(); }
				catch (Exception)  {   } 
			}	);
		}
		
		public void OnNewArea(bool newGame, ISnoArea area)  
		{
			if (newGame)  
			{
				ResourceMaxPlay = false;	ResourceMinPlay = false;				
			}
		}

		public void AfterCollect()  
		{
			if ( Hud.Game.IsInGame && (Hud.Game.Me.HeroClassDefinition.HeroClass==HeroClass.Necromancer) ) 
			{                
				if (!Hud.Game.Me.Powers.UsedSkills.Any(s => s.SnoPower.Sno == 462089 && s.Rune == 1)) return;
				if (Hud.Game.SpecialArea == SpecialArea.GreaterRift) 
				{
					float Resource = Hud.Game.Me.Stats.ResourcePctEssence;
					if (Resource > ResourceLow) { ResourceMinPlay = true; }
					else if (ResourceMinPlay == true) 
					{ 
						if (LowNotify && !string.IsNullOrWhiteSpace(LowNotifyWav) ) { Play_Sound(LowNotifyWav);  }    
						ResourceMinPlay = false;            	           
					} 

					if (Resource < ResourceHigh) { ResourceMaxPlay = true; }
					else if (ResourceMaxPlay == true) 
					{ 
						if (HighNotify && !string.IsNullOrWhiteSpace(HighNotifyWav)) { Play_Sound(HighNotifyWav);  }    
						ResourceMaxPlay = false;                           
					}
				}
				else 
				{
					ResourceMaxPlay = false; ResourceMinPlay = false; 
				}
			}             
		}
	}
}