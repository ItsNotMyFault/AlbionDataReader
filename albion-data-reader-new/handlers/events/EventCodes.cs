namespace Albion.Network
{
    public enum EventCodes
    {
        evevLeave = 1,
        evJoinFinished,
        evMove,
        evPartyInvitation,
        evChangeEquipment,
        evHealthUpdate,
        evEnergyUpdate,
        evDamageShieldUpdate,
        evCraftingFocusUpdate,
        evActiveSpellEffectsUpdate,
        evResetCooldowns,
        evGetAttacked,
        evCastStart,
        evCastCancel,
        evCastTimeUpdate,
        evCastFinished,
        evCastSpell,
        evCastHit,
        evCastHits,
        evChannelingEnded,
        evAttackBuilding,
        evInventoryPutItem,
        evMovedItemInInventory,
        evItemMovedInInventory,
        evStackingItem,
        evNewSimpleItem,
        evSplitItemStack,
        evNewJournalItem,
        evNewLaborerItem,
        evMove2,
        evNewSimpleHarvestableObjectList,
        evStopsMoving,
        evNewSilverObject,
        evNewBuilding,
        evMove3,
        evMobChangeState,
        evFactionBuildingInfo,
        evCraftBuildingInfo,
        evRepairBuildingInfo,
        evNPCEnergyMage,
        evConstructionSiteInfo,
        evPlayerBuildingInfo,
        evFarmBuildingInfo,
        evTutorialBuildingInfo,
        evLaborerObjectInfo,
        evLaborerObjectJobInfo,
        evMarketPlaceBuildingInfo,
        evUnknownMan,
        evHarvestCancel,
        evHarvestStarted,
        evTakeSilver,
        evGatherFinished,
        evActionOnBuildingCancel,
        evActionOnBuildingFinished,
        evItemRerollQualityStart,
        evItemRerollQualityCancel,
        evItemRerollQualityFinished,
        evInstallResourceStart,
        evInstallResourceCancel,
        evInstallResourceFinished,
        evCraftItemFinished,
        evLogoutCancel,
        evChatMessage,
        evChatSay,
        evChatWhisper,
        evChatMuted,
        evPlayEmote,
        evStopEmote,
        evSystemMessage,
        evUtilityTextMessage,
        evUpdateMoney,
        evUpdateFame,
        evUpdateLearningPoints,
        evUpdateReSpecPoints,
        evUpdateCurrency,
        evUpdateFactionStanding,
        evRespawn,
        evServerDebugLog,
        evCharacterEquipmentChanged,
        evRegenerationHealthChanged,
        evRegenerationEnergyChanged,
        evRegenerationMountHealthChanged,
        evRegenerationCraftingChanged,
        evRegenerationHealthEnergyComboChanged,
        evRegenerationPlayerComboChanged,
        evDurabilityChanged,
        evNewLoot,
        evOpenChest,
        evCloseChest,
        evGuildUpdate,
        evGuildPlayerUpdated,
        evInvitedToGuild,
        evPlayerLogsIn,
        evPlayerGetonline,
        evObjectEvent,
        evNewMonolithObject,
        evNewSiegeCampObject,
        evNewOrbObject,
        evNewCastleObject,
        evNewSpellEffectArea,
        evSpellIsCast,
        evUpdateChainSpell,
        evCastSpell2,
        evStartMatch,
        evStartTerritoryMatchInfos,
        evStartArenaMatchInfos,
        evEndTerritoryMatch,
        evEndArenaMatch,
        evMatchUpdate,
        evActiveMatchUpdate,
        evNewMob,
        evDebugAggroInfo,
        evDebugVariablesInfo,
        evDebugReputationInfo,
        evDebugDiminishingReturnInfo,
        evDebugSmartClusterQueueInfo,
        evClaimOrbStart,
        evClaimOrbFinished,
        evClaimOrbCancel,
        evOrbUpdate,
        evOrbClaimed,
        evNewWarCampObject,
        evNewMatchLootChestObject,
        evNewArenaExit,
        evGuildMemberTerritoryUpdate,
        evInvitedMercenaryToMatch,
        evClusterInfoUpdate,
        evForcedMovement,
        evForcedMovementCancel,
        evCharacterStats,
        evCharacterStatsKillHistory,
        evCharacterStatsDeathHistory,
        evGuildInfoG,
        evKillHistoryDetails,
        evFullAchievementInfo,
        evFinishedAchievement,
        evAchievementProgressInfo,
        evFullAchievementProgressInfo,
        evFullTrackedAchievementInfo,
        evFullAutoLearnAchievementInfo,
        evQuestGiverQuestOffered,
        evQuestGiverDebugInfo,
        evConsoleEvent,
        evTimeSync,
        evChangeAvatar,
        evChangeMountSkin,
        evGameEvent,
        evUnknown3,
        evDied,
        evKnockedDown,
        evMatchPlayerJoinedEvent,
        evMatchPlayerStatsEvent,
        evMatchPlayerStatsCompleteEvent,
        evMatchTimeLineEventEvent,
        evMatchPlayerMainGearStatsEvent,
        evMatchPlayerChangedAvatarEvent,
        evInvitationPlayerTrade,
        evPlayerTradeStart,
        evPlayerTradeCancel,
        evPlayerTradeUpdate,
        evPlayerTradeFinished,
        evPlayerTradeAcceptChange,
        evMiniMapPing,
        evMarketPlaceNotification,
        evDuellingChallengePlayer,
        evNewDuellingPost,
        evPingOnMap,
        evDuelEnded,
        evDuelDenied,
        evDuelLeftArea,
        evDuelReEnteredArea,
        evNewRealEstate,
        evMiniMapOwnedBuildingsPositions,
        evRealEstateListUpdate,
        evGuildLogoUpdate,
        evGuildLogoChanged,
        evPlaceableObjectPlace,
        evPlaceableObjectPlaceCancel,
        evFurnitureObjectBuffProviderInfo,
        evFurnitureObjectCheatProviderInfo,
        evFarmableObjectInfo,
        evNewUnreadMails,
        evMailNotification = 183,
        evStartLogout,
        evMove1,
        evJoinedChatChannel,
        evLeftChatChannel,
        evRemovedChatChannel,
        evAccessStatus,
        evMounted,
        evMountStart,
        evCharacterMountsUp,
        evNewTravelpoint,
        evNewIslandAccessPoint,
        evZonethroughNewZone,
        evPlayerZoneInTheMap,//there is a max range on this
        evUpdateChatSettings,
        evResurrectionOffer,
        evResurrectionReply,
        evLootEquipmentChanged,
        evUpdateUnlockedGuildLogos,
        evUpdateUnlockedAvatars,
        evUpdateUnlockedAvatarRings,
        evUpdateUnlockedBuildings,
        evNewIslandManagement,
        evNewTeleportStone,
        evCloak,
        evTeleport,
        evPartySilverGained,
        evPartyLootSettingChangedPlayer,
        evPartyPlayerSomething,
        evPartyChangedOrder,
        evPartyInvitationPlayerBusy,
        evPartySomething3,
        evPartyCreated,
        evPartyPlayerLeft,
        evPartyPlayerJoined,
        evPartyPlayerSomething2,
        evPartyPlayerLeave,
        evPartyLeaderChanged,
        evPartySetRoleFlag,
        evSpellCooldownUpdate,
        evNewHellgate,
        evPartyInvitationDeclinedBusy,
        evNewExpeditionExit,
        evNewExpeditionNarrator,
        evExitEnterStart,
        evExitEnterCancel,
        evExitEnterFinished,
        evHellClusterTimeUpdate,
        evNewQuestGiverObject,
        evFullQuestInfo,
        evQuestProgressInfo,
        evQuestGiverInfoForPlayer,
        evFullExpeditionInfo,
        evExpeditionQuestProgressInfo,
        evInvitedToExpedition,
        evExpeditionRegistrationInfo,
        evEnteringExpeditionStart,
        evEnteringExpeditionCancel,
        evRewardGranted,
        evArenaRegistrationInfo,
        evEnteringArenaStart,
        evEnteringArenaCancel,
        evEnteringArenaLockStart,
        evEnteringArenaLockCancel,
        evInvitedToArenaMatch,
        evPlayerCounts,
        evInCombatStateUpdate,
        evOtherGrabbedLoot,
        evSiegeCampClaimStart,
        evSiegeCampClaimCancel,
        evSiegeCampClaimFinished,
        evSiegeCampScheduleResult,
        evTreasureChestUsingStart,
        evTreasureChestUsingFinished,
        evTreasureChestUsingCancel,
        evUnknown2,
        evTreasureChestForceCloseInventory,
        evPremiumChanged,
        evPremiumExtended,
        evPremiumLifeTimeRewardGained,
        evLaborerGotUpgraded,
        evJournalGotFull,
        evJournalFillError,
        evFriendRequest,
        evFriendRequestInfos,
        evFriendInfos,
        evFriendRequestAnswered,
        evFriendOnlineStatus,
        evFriendRequestCanceled,
        evFriendRemoved,
        evFriendUpdated,
        evPlayerLoggsIn,
        evPartyLootItemsRemoved,
        evReputationUpdate,
        evPlayerLoginOrLogOff,
        evDefenseUnitAttackEnd,
        evDefenseUnitAttackDamage,
        evUnrestrictedPvpZoneUpdate,
        evReputationImplicationUpdate,
        evNewMountObject,
        evMountHealthUpdate,
        evMountCooldownUpdate,
        evNewExpeditionAgent,
        evNewExpeditionCheckPoint,
        evExpeditionStartEvent,
        evVoteEvent,
        evRatingEvent,
        evNewArenaAgent,
        evBoostFarmable,
        evUseFunction,
        evNewPortalEntrance,
        evNewPortalExit,
        evNewRandomDungeonExit,
        evWaitingQueueUpdate,
        evPlayerMovementRateUpdate,
        evObserveStart,
        evMinimapZergs,
        evPaymentTransactions,
        evPerformanceStatsUpdate,
        evOverloadModeUpdate,
        evDebugDrawEvent,
        evRecordCameraMove,
        evRecordStart,
        evTerritoryClaimStart,
        evTerritoryClaimCancel,
        evTerritoryClaimFinished,
        evTerritoryScheduleResult,
        evUpdateAccountState,
        evStartDeterministicRoam,
        evGuildFullAccessTagsUpdated,
        evGuildAccessTagUpdated,
        evGvgSeasonUpdate,
        evGvgSeasonCheatCommand,
        evSeasonPointsByKillingBooster,
        evFishingStart,
        evFishingCast,
        evFishingCatch,
        evFishingFinished,
        evFishingCancel,
        evNewFloatObject,
        evNewFishingZoneObject,
        evFishingMiniGame,
        evSteamAchievementCompleted,
        evUpdatePuppet,
        evChangeFlaggingFinished,
        evNewOutpostObject,
        evOutpostUpdate,
        evOutpostClaimed,
        evOutpostReward,
        evOverChargeEnd,
        evOverChargeStatus,
        evPartyFinderFullUpdate,
        evPartyFinderUpdate,
        evPartyFinderApplicantsUpdate,
        evPartyFinderEquipmentSnapshot,
        evPartyFinderJoinRequestDeclined,
        evNewUnlockedPersonalSeasonRewards,
        evPersonalSeasonPointsGained,
        evEasyAntiCheatMessageToClient,
        evMatchLootChestOpeningStart,
        evMatchLootChestOpeningFinished,
        evMatchLootChestOpeningCancel,
        evNotifyCrystalMatchReward,
        evCrystalRealmFeedback,
        evNewLocationMarker,
        evNewTutorialBlocker,
        evNewTileSwitch,
        evNewInformationProvider,
        evNewDynamicGuildLogo,
        evTutorialUpdate,
        evTriggerHintBox,
        evRandomDungeonPositionInfo,
        evNewLootChest,
        evUpdateLootChest,
        evLootChestOpened,
        evNewShrine,
        evUpdateShrine,
        evMutePlayerUpdate,
        evShopTileUpdate,
        evShopUpdate,
        evUnknown4,
        evUnlockVanityUnlock,
        evCustomizationChanged,
        evBaseVaultInfo,
        evGuildVaultInfo,
        evBankVaultInfo,
        evRecoveryVaultPlayerInfo,
        evRecoveryVaultGuildInfo,
        evUpdateWardrobe,
        evCastlePhaseChanged,
        evGuildAccountLogEvent,
        evNewHideoutObject,
        evNewHideoutManagement,
        evNewHideoutExit,
        evInitHideoutAttackStart,
        evInitHideoutAttackCancel,
        evInitHideoutAttackFinished,
        evHideoutManagementUpdate,
        evIpChanged,
        evSmartClusterQueueUpdateInfo,
        evSmartClusterQueueActiveInfo,
        evOpenPersonalChest,
        evSmartClusterQueueInvite,
        evReceivedGvgSeasonPoints,
        evTerritoryBonusLevelUpdate,
        evOpenWorldAttackScheduleStart,
        evOpenWorldAttackScheduleFinished,
        evOpenWorldAttackScheduleCancel,
        evOpenWorldAttackConquerStart,
        evOpenWorldAttackConquerFinished,
        evOpenWorldAttackConquerCancel,
        evOpenWorldAttackConquerStatus,
        evOpenWorldAttackStart,
        evOpenWorldAttackEnd,
        evNewRandomResourceBlocker,
        evUnknown5,
        evUnknown6,
        evUnknown7,
        evUnknown8,
        evUnknown9,
        evUnknown10,
        evUnknown11,
        evUnknown12,
        evUnknown13,
        evUnknown14,
        evUnknown15,
        evUnknown16,
        evUnknown17,
        evUnknown18,
        evUnknown19,
        evUnknown20,
        evUnknown21,
        evUnknown22,
        evUnknown23,
        evUnknown24,
        evUnknown25,
        evUnknown26,
        evUnknown27,
        evUnknown28,
        evUnknown29,
        evUnknown30,
        evUnknown31,
        evUnknown32,
        evUnknown33,
        evUnknown34,
        evUnknown35,
        evUnknown36,
        evUnknown37,
        evUnknown38,
        evUnknown39,
        evUnknown40,
        evUnknown41,
        evUnknown42,
        evUnknown43,
        evUnknown44,
        evUnknown45,
        evUnknown46,
        evUnknown47,
        evUnknown48,
        evUnknown49,
        evUnknown50,
        evUnknown51

    }
}
