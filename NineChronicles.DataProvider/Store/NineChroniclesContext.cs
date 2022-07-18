namespace NineChronicles.DataProvider.Store
{
    using Microsoft.EntityFrameworkCore;
    using NineChronicles.DataProvider.Store.Models;

    public class NineChroniclesContext : DbContext
    {
        public NineChroniclesContext(DbContextOptions<NineChroniclesContext> options)
            : base(options)
        {
        }

        public DbSet<HackAndSlashModel>? HackAndSlashes { get; set; }

        public DbSet<StageRankingModel>? StageRanking { get; set; }

        public DbSet<CombinationConsumableModel>? CombinationConsumables { get; set; }

        public DbSet<CombinationEquipmentModel>? CombinationEquipments { get; set; }

        public DbSet<ItemEnhancementModel>? ItemEnhancements { get; set; }

        public DbSet<CraftRankingInputModel>? CraftRankings { get; set; }

        public DbSet<CraftRankingOutputModel>? CraftRankingsOutput { get; set; }

        public DbSet<AvatarModel>? Avatars { get; set; }

        public DbSet<AgentModel>? Agents { get; set; }

        public DbSet<EquipmentModel>? Equipments { get; set; }

        public DbSet<EquipmentRankingModel>? EquipmentRankings { get; set; }

        public DbSet<AbilityRankingModel>? AbilityRankings { get; set; }

        public DbSet<ShopHistoryEquipmentModel>? ShopHistoryEquipments { get; set; }

        public DbSet<ShopHistoryCostumeModel>? ShopHistoryCostumes { get; set; }

        public DbSet<ShopHistoryMaterialModel>? ShopHistoryMaterials { get; set; }

        public DbSet<ShopHistoryConsumableModel>? ShopHistoryConsumables { get; set; }

        public DbSet<StakeModel>? Stakings { get; set; }

        public DbSet<ClaimStakeRewardModel>? ClaimStakeRewards { get; set; }

        public DbSet<MigrateMonsterCollectionModel>? MigrateMonsterCollections { get; set; }

        public DbSet<GrindingModel>? Grindings { get; set; }

        public DbSet<ItemEnhancementFailModel>? ItemEnhancementFails { get; set; }

        public DbSet<UnlockEquipmentRecipeModel>? UnlockEquipmentRecipes { get; set; }

        public DbSet<UnlockWorldModel>? UnlockWorlds { get; set; }

        public DbSet<ReplaceCombinationEquipmentMaterialModel>? ReplaceCombinationEquipmentMaterials { get; set; }

        public DbSet<HasRandomBuffModel>? HasRandomBuffs { get; set; }

        public DbSet<HasWithRandomBuffModel>? HasWithRandomBuffs { get; set; }

        public DbSet<JoinArenaModel>? JoinArenas { get; set; }

        public DbSet<BattleArenaModel>? BattleArenas { get; set; }

        public DbSet<ShopEquipmentModel>? ShopEquipments { get; set; }

        public DbSet<ShopConsumableModel>? ShopConsumables { get; set; }

        public DbSet<ShopCostumeModel>? ShopCostumes { get; set; }

        public DbSet<ShopMaterialModel>? ShopMaterials { get; set; }

        public DbSet<BattleArenaRankingModel>? BattleArenaRanking { get; set; }
    }
}
