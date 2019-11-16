// This file is managed by TurboHUD Plugin Manager, it is used as a database, DO NOT MODIFY.
using Turbo.Plugins.Default;

namespace Turbo.Plugins.User
{

	public class PluginManagerPlugin : BasePlugin, ICustomizer
	{

		public PluginManagerPlugin()
		{
			Enabled = true;
		}

		public override void Load(IController hud)
		{
			base.Load(hud);
		}

		public void Customize()
		{
			//BM
			Hud.TogglePlugin<BM.SkeletalMageSingularityEssenceConfig>(true);
			Hud.TogglePlugin<BM.SkeletalMageSingularityEssencePlugin>(true);
			//Default
			Hud.TogglePlugin<BountyTablePlugin>(true);
			Hud.TogglePlugin<DamageBonusPlugin>(true);
			Hud.TogglePlugin<DebugPlugin>(false);
			Hud.TogglePlugin<ExperienceOverBarPlugin>(true);
			Hud.TogglePlugin<GameInfoPlugin>(true);
			Hud.TogglePlugin<NetworkLatencyPlugin>(true);
			Hud.TogglePlugin<NotifyAtRiftPercentagePlugin>(true);
			Hud.TogglePlugin<ParagonCapturePlugin>(true);
			Hud.TogglePlugin<PortraitBottomStatsPlugin>(true);
			Hud.TogglePlugin<ResourceOverGlobePlugin>(true);
			Hud.TogglePlugin<RiftPlugin>(true);
			Hud.TogglePlugin<WaypointQuestsPlugin>(true);
			Hud.TogglePlugin<ChestPlugin>(true);
			Hud.TogglePlugin<ClickableChestGizmoPlugin>(false);
			Hud.TogglePlugin<CursedEventPlugin>(true);
			Hud.TogglePlugin<DeadBodyPlugin>(false);
			Hud.TogglePlugin<GlobePlugin>(true);
			Hud.TogglePlugin<OculusPlugin>(true);
			Hud.TogglePlugin<PortalPlugin>(true);
			Hud.TogglePlugin<RackPlugin>(true);
			Hud.TogglePlugin<ShrinePlugin>(true);
			Hud.TogglePlugin<CheatDeathBuffFeederPlugin>(true);
			Hud.TogglePlugin<ConventionOfElementsBuffListPlugin>(true);
			Hud.TogglePlugin<MiniMapLeftBuffListPlugin>(true);
			Hud.TogglePlugin<MiniMapRightBuffListPlugin>(true);
			Hud.TogglePlugin<PlayerBottomBuffListPlugin>(true);
			Hud.TogglePlugin<PlayerLeftBuffListPlugin>(true);
			Hud.TogglePlugin<PlayerRightBuffListPlugin>(true);
			Hud.TogglePlugin<PlayerTopBuffListPlugin>(true);
			Hud.TogglePlugin<TopLeftBuffListPlugin>(true);
			Hud.TogglePlugin<TopRightBuffListPlugin>(true);
			Hud.TogglePlugin<CooldownSoundPlayerPlugin>(true);
			Hud.TogglePlugin<GroundLabelDecoratorPainterPlugin>(true);
			Hud.TogglePlugin<BloodShardPlugin>(false);
			Hud.TogglePlugin<InventoryAndStashPlugin>(true);
			Hud.TogglePlugin<InventoryFreeSpacePlugin>(false);
			Hud.TogglePlugin<InventoryKanaiCubedItemsPlugin>(true);
			Hud.TogglePlugin<InventoryMaterialCountPlugin>(true);
			Hud.TogglePlugin<StashPreviewPlugin>(true);
			Hud.TogglePlugin<StashUsedSpacePlugin>(true);
			Hud.TogglePlugin<CosmeticItemsPlugin>(true);
			Hud.TogglePlugin<HoveredItemInfoPlugin>(true);
			Hud.TogglePlugin<ItemsPlugin>(true);
			Hud.TogglePlugin<PickupRangePlugin>(true);
			Hud.TogglePlugin<AttributeLabelListPlugin>(true);
			Hud.TogglePlugin<TopExperienceStatistics>(true);
			Hud.TogglePlugin<MarkerPlugin>(true);
			Hud.TogglePlugin<SceneHintPlugin>(true);
			Hud.TogglePlugin<DangerousMonsterPlugin>(true);
			Hud.TogglePlugin<EliteMonsterAffixPlugin>(true);
			Hud.TogglePlugin<EliteMonsterSkillPlugin>(true);
			Hud.TogglePlugin<ExplosiveMonsterPlugin>(true);
			Hud.TogglePlugin<GoblinPlugin>(true);
			Hud.TogglePlugin<MonsterPackPlugin>(false);
			Hud.TogglePlugin<MonsterRiftProgressionColoringPlugin>(true);
			Hud.TogglePlugin<StandardMonsterPlugin>(true);
			Hud.TogglePlugin<TopMonsterHealthBarPlugin>(true);
			Hud.TogglePlugin<BannerPlugin>(true);
			Hud.TogglePlugin<HeadStonePlugin>(true);
			Hud.TogglePlugin<MultiplayerExperienceRangePlugin>(false);
			Hud.TogglePlugin<OtherPlayersPlugin>(true);
			Hud.TogglePlugin<PlayerSkillPlugin>(true);
			Hud.TogglePlugin<SkillRangeHelperPlugin>(true);
			Hud.TogglePlugin<OriginalHealthPotionSkillPlugin>(true);
			Hud.TogglePlugin<OriginalSkillBarPlugin>(true);
			Hud.TogglePlugin<UiHiddenPlayerSkillBarPlugin>(true);
			//Resu
			Hud.TogglePlugin<Resu.AriadnesThreadPlugin>(true);
			Hud.TogglePlugin<Resu.BattleTagAboveBanner>(true);
			Hud.TogglePlugin<Resu.ChannelingPlugin>(true);
			Hud.TogglePlugin<Resu.CloudofBatsPlugin>(false);
			Hud.TogglePlugin<Resu.CraftCountPlugin>(true);
			Hud.TogglePlugin<Resu.CraftersDelightPlugin>(true);
			Hud.TogglePlugin<Resu.CrierSellerPlugin>(false);
			Hud.TogglePlugin<Resu.CustomLifeWarningPlugin>(true);
			Hud.TogglePlugin<Resu.DangerPlugin>(true);
			Hud.TogglePlugin<Resu.DarkerDiablo3Plugin>(true);
			Hud.TogglePlugin<Resu.DeluxeInventoryFreeSpacePlugin>(true);
			Hud.TogglePlugin<Resu.DeluxeShrineLabelsPlugin>(true);
			Hud.TogglePlugin<Resu.DiadrasFirstGemPlugin>(true);
			Hud.TogglePlugin<Resu.EquippedItemDurabilityPlugin>(true);
			Hud.TogglePlugin<Resu.GroupGRLevelAdviserPlugin>(true);
			Hud.TogglePlugin<Resu.HotEnablerDisablerPlugin>(true);
			Hud.TogglePlugin<Resu.HuntersVengeancePlugin>(false);
			Hud.TogglePlugin<Resu.ImmortalKingsCallPlugin>(false);
			Hud.TogglePlugin<Resu.ItemPerfectionPlugin>(true);
			Hud.TogglePlugin<Resu.NextHeroPlugin>(false);
			Hud.TogglePlugin<Resu.OtherPlayersHeadsPlugin>(true);
			Hud.TogglePlugin<Resu.ParagonPercentagePlugin>(true);
			Hud.TogglePlugin<Resu.PotionPerfectionPlugin>(false);
			Hud.TogglePlugin<Resu.PrimalAncientProbabilityPlugin>(true);
			Hud.TogglePlugin<Resu.StatsCarouselPlugin>(true);
			Hud.TogglePlugin<Resu.TimeEverywherePlugin>(true);
			Hud.TogglePlugin<Resu.UnscathedMonsterShowerPlugin>(true);
			Hud.TogglePlugin<Resu.UrshisGiftPlugin>(true);
			//RNN
			Hud.TogglePlugin<RNN.NotifyEssenceMages>(false);
		}
	}
}